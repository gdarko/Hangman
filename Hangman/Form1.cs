using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{

    public partial class HangmanForm : Form
    {
        /// <summary>
        /// Information about the current game
        /// </summary>
        Game game;

        Graphics g;

        /// <summary>
        /// Timer for the game
        /// </summary>
        private static readonly int TIME = 240;//240 sekundi = 4 minuti
        private int TimeElapsed;

        public HangmanForm()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            NewGame window = new NewGame();
            panel2.Visible = false;
            btnStartGame.Focus();
            btnPause.Visible = false;
            btnHelp.Visible = false;
            btnResults.Visible = false;
            lblPogodiZbor.Visible = false;
            easyToolStripMenuItem.Checked = true;

            // Graphics g = pnlBody.CreateGraphics();


            // Show the NewGame form on initialization and get the results from it
            if (window.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                game = new Game(window.result, this);
                tbIme.Text = game.Player.FirstName;
                tbPrekar.Text = game.Player.NickName;
                tbPrezime.Text = game.Player.LastName;
                lblPogodiZbor.Text = game.Session.EncryptedWord;
            }
            else
            {
                MessageBox.Show("Играта не може да започне!", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(1);
            }
        }



        private void btnResults_Click(object sender, EventArgs e)
        {
            HighScores window = new HighScores(game.DB);
            window.ShowDialog();
        }


        private void btnPause_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("ИГРАТА Е ПАУЗИРАНА", "Паузирај", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (response == DialogResult.OK)
            {
                timerRemainingTime.Stop();
                timerRemainingTime.Enabled = false;
                btnStartGame.Enabled = false;
                btnResults.Enabled = true;
                btnPause.Visible = false;
                btnContinue.Visible = true;
                btnHelp.Enabled = false;
                btnStartGame.ForeColor = Color.White;
                lblPogodiZbor.Visible = false;
                panel2.Visible = false;
                btnHelp.Visible = false;
                btnStartGame.Visible = false;
            }
        }


        private void formBesilka_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TimeElapsed != 0)
            {
                DialogResult result = MessageBox.Show("Играта сеуште не е завршена?", "Излези!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.No)
                {
                    DialogResult re = MessageBox.Show("Дали сакате да го зачувате резултатот во базата?", "Резултат", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (dbSaveResult())
                        {
                            MessageBox.Show("Резултатот е успешно зачуван!", "Резултат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Настана грешка при зачувување на вашиот резултат!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                Application.Exit();
            }
            else
            {
                DialogResult re = MessageBox.Show("Дали сакате да го зачувате резултатот во базата?", "Резултат", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == System.Windows.Forms.DialogResult.Yes)
                {
                    if (dbSaveResult())
                    {
                        MessageBox.Show("Резултатот е успешно зачуван!", "Резултат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Настана грешка при зачувување на вашиот резултат!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        /// <summary>
        /// Function dbSaveResult()
        /// @return bool
        /// Helper Function to save the user score
        /// </summary>
        private bool dbSaveResult()
        {
            string firstname = game.Player.FirstName;
            string nickname = game.Player.NickName;
            string lastname = game.Player.LastName;
            int points = game.Player.Points;
            bool state = game.DB.insertResult(firstname, nickname, lastname, points);
            return state;

        }
        /// <summary>
        /// Used to get the panel(pnlBody) for drawing the body
        /// </summary>
        public PictureBox pbGuyBox
        {
            get { return pbGuy; }
            set { pbGuy = value; }
        }

        private void timerRemainingTime_Tick(object sender, EventArgs e)
        {
            TimeElapsed++;
            timerRemainingTime.Interval = 1000;//1 sekunda = 1000 milisekundi
            timerRemainingTime.Enabled = true;
            if (TimeElapsed == TIME)
            {
                MessageBox.Show("Вашето време истече!", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formBesilka_FormClosing(sender, null);
                btnPause.Enabled = false;
                btnHelp.Enabled = false;
                label6.Visible = false;
                lblRemainingTime.Visible = false;
                timerRemainingTime.Enabled = false;
                timerRemainingTime.Stop();
            }
            UpdateTime();
        }
        private void UpdateTime()
        {
            int TimeLeft = TIME - TimeElapsed;
            int min = TimeLeft / 60;
            int sec = TimeLeft % 60;
            lblRemainingTime.Text = string.Format("{0:D2}:{1:D2}", min, sec);

        }


        private void излезToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TimeElapsed != 0)
            {
                DialogResult result = MessageBox.Show("Играта сеуште не е завршена?", "Излези!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.No)
                {
                    formBesilka_FormClosing(sender, null);
                    Application.Exit();
                }
            }
            else
            {
                formBesilka_FormClosing(sender, null);
            }
        }

        private void помошToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructions h = new Instructions();
            h.ShowDialog();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (TimeElapsed == 0)
            {
                lblPogodiZbor.Text = game.Session.EncryptedWord;
                lblRemainingTime.Visible = true;
                label6.Visible = true;
                lblPoeni.Text = Convert.ToString(game.GetPoints());
                btnPause.Enabled = true;
                UpdateTime();
                timerRemainingTime.Start();
                panel2.Visible = true;
                lblPogodiZbor.Visible = true;
                btnPause.Visible = true;
                btnHelp.Visible = true;
                btnResults.Visible = true;
                playSoundtrack(Hangman.Properties.Resources.MainTheme);

            }
            else
            {
                DialogResult response = MessageBox.Show("Тековната игра сеуште трае!", "Нова игра!?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    DialogResult re = MessageBox.Show("Со почнување на нова игра моментално освоените поени ви се бришат!!",
                        "Потврди?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re != DialogResult.No)
                    {
                        TimeElapsed = 0;
                        timerRemainingTime.Start();
                    }
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timerRemainingTime.Start();
            timerRemainingTime.Enabled = true;
            lblPogodiZbor.Visible = true;
            panel2.Visible = true;
            btnContinue.Visible = false;
            btnHelp.Visible = true;
            btnResults.Visible = true;
            btnPause.Visible = true;
            btnStartGame.Visible = true;
            btnStartGame.Enabled = true;
            btnHelp.Enabled = true;
        }


        private void листаСоРезултатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TimeElapsed != 0)
            {
                MessageBox.Show("Не можете да ги видите резултатите додека играта трае!", "Информација!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HighScores window = new HighScores(game.DB);
                window.ShowDialog();
            }
        }



        private void новаИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Дали сте сигурни?", "Нова игра?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                TimeElapsed = 0;
                UpdateTime();
            }
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem.Checked = true;
            normalToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = false;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = true;
            hardToolStripMenuItem.Checked = false;
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easyToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            hardToolStripMenuItem.Checked = true;
        }

        // Stop flockering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        // Keyboard
        private void charQ_Click(object sender, EventArgs e) { Guess('q'); }
        private void charW_Click(object sender, EventArgs e) { Guess('w'); }
        private void charE_Click(object sender, EventArgs e) { Guess('e'); }
        private void charR_Click(object sender, EventArgs e) { Guess('r'); }
        private void charT_Click(object sender, EventArgs e) { Guess('t'); }
        private void charY_Click(object sender, EventArgs e) { Guess('y'); }
        private void charU_Click(object sender, EventArgs e) { Guess('u'); }
        private void charI_Click(object sender, EventArgs e) { Guess('i'); }
        private void charO_Click(object sender, EventArgs e) { Guess('o'); }
        private void charA_Click(object sender, EventArgs e) { Guess('a'); }
        private void charS_Click(object sender, EventArgs e) { Guess('s'); }
        private void charD_Click(object sender, EventArgs e) { Guess('d'); }
        private void charF_Click(object sender, EventArgs e) { Guess('f'); }
        private void charG_Click(object sender, EventArgs e) { Guess('g'); }
        private void charH_Click(object sender, EventArgs e) { Guess('h'); }
        private void charJ_Click(object sender, EventArgs e) { Guess('j'); }
        private void charK_Click(object sender, EventArgs e) { Guess('k'); }
        private void charL_Click(object sender, EventArgs e) { Guess('l'); }
        private void charZ_Click(object sender, EventArgs e) { Guess('z'); }
        private void charX_Click(object sender, EventArgs e) { Guess('x'); }
        private void charC_Click(object sender, EventArgs e) { Guess('c'); }
        private void charV_Click(object sender, EventArgs e) { Guess('v'); }
        private void charB_Click(object sender, EventArgs e) { Guess('b'); }
        private void charN_Click(object sender, EventArgs e) { Guess('n'); }
        private void charM_Click(object sender, EventArgs e) { Guess('m'); }
        private void charP_Click(object sender, EventArgs e) { Guess('p'); }



        private void Guess(char c)
        {
            int State = game.UpdateSession(c);
            if (State == Globals.GUESS_SUCCESS)
            {
                // playSimpleSound(Hangman.Properties.Resources.correctanswer);

            }
            else if (State == Globals.GUESS_NOT_SUCCESS)
            {
                //playSimpleSound(Hangman.Properties.Resources.wronganswer);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Многу ни е жал!\nВие сте обесени.\nПробајте повторно :(");
                MessageBox.Show(sb.ToString(), "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timerRemainingTime.Stop();
                TimeElapsed = 0;
            }

            lblPogodiZbor.Text = game.Session.EncryptedWord;
            lblPoeni.Text = Convert.ToString(game.GetPoints());
        }

        private void playSimpleSound(System.IO.Stream wav)
        {
            SoundPlayer simpleSound = new SoundPlayer(wav);
            simpleSound.Play();
        }
        private void playSoundtrack(System.IO.Stream wav)
        {
            SoundPlayer soundtrack = new SoundPlayer(wav);
            soundtrack.PlayLooping();
        }
    }
}
