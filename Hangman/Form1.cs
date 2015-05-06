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

        /// <summary>
        /// Timer for the game
        /// </summary>
        private int TimeElapsed;

        public HangmanForm()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            NewGame window = new NewGame();
            lblPogodiZbor.Visible = false;
            easyToolStripMenuItem.Checked = true;
            disableKeyboardButtons();

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

            
        /// <summary>
        /// 
        /// All of the below functions are events. They are triggered
        /// once the player do some action!
        /// 
        /// </summary>

        /// <summary>
        /// 
        ///  BUTTON EVENTS
        /// 
        /// </summary>
        private void btnResults_Click(object sender, EventArgs e)
        {
            HighScores window = new HighScores(game.DB);
            window.ShowDialog();
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (game.isRunning)
            {
                DialogResult response = MessageBox.Show("ИГРАТА Е ПАУЗИРАНА", "Паузирај", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timerRemainingTime.Stop();
                timerRemainingTime.Enabled = false;
                btnResults.Enabled = true;
                btnHelp.Enabled = false;
                btnStartGame.Visible = false;
                lblPogodiZbor.Visible = false;
                btnHelp.Visible = false;
                btnStartGame.Visible = false;
                btnPause.Text = "Continue";
                disableKeyboardButtons();
                game.isRunning = false;
            }
            else
            {
                timerRemainingTime.Start();
                timerRemainingTime.Enabled = true;
                lblPogodiZbor.Visible = true;
                btnHelp.Visible = true;
                btnResults.Visible = true;
                btnStartGame.Visible = false;
                btnHelp.Enabled = true;
                btnPause.Text = "Pause";
                enableButtonsKeyboard();
                game.isRunning = true;
            }

        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (TimeElapsed == 0)
            {
                enableButtonsKeyboard();
                lblPogodiZbor.Text = game.Session.EncryptedWord;
                lblPoeni.Text = Convert.ToString(game.GetPoints());
                lblRemainingTime.Visible = true;
                label6.Visible = true;
                btnPause.Enabled = true;
                UpdateTime();
                timerRemainingTime.Start();
                pnlKeyboard.Visible = true;
                lblPogodiZbor.Visible = true;
                btnPause.Visible = true;
                btnStartGame.Visible = false;
                playSound(Hangman.Properties.Resources.MainTheme, true /* Looping */);

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

        /// <summary>
        ///  OTHER EVENTS
        ///  Closing form, timer tick, etc.
        /// </summary>
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
                Application.Exit();
            }
        }
        private void timerRemainingTime_Tick(object sender, EventArgs e)
        {
            TimeElapsed++;
            timerRemainingTime.Interval = 1000;//1 sekunda = 1000 milisekundi
            timerRemainingTime.Enabled = true;
            if (TimeElapsed == Globals.TOTAL_GAME_TIME)
            {
                MessageBox.Show("Вашето време истече!", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formBesilka_FormClosing(sender, null);
                btnPause.Enabled = false;
                btnHelp.Enabled = false;
                label6.Visible = false;
                lblRemainingTime.Visible = false;
                timerRemainingTime.Enabled = false;
                timerRemainingTime.Stop();
                btnStartGame.Visible = true;
            }
            UpdateTime();
        }

        /// <summary>
        ///  MENU TOOLSTRIP EVENTS
        /// </summary>
        private void listresTSMI_Click(object sender, EventArgs e)
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
        private void closeTSMI_Click(object sender, EventArgs e)
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
        private void helpTSMI_Click(object sender, EventArgs e)
        {
            Instructions h = new Instructions();
            h.ShowDialog();
        }
        private void newGameTSMI_Click(object sender, EventArgs e)
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
        private void aboutTSMI_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void helpToolStripButton1_Click(object sender, EventArgs e)
        {
            Instructions i = new Instructions();
            i.ShowDialog();
        }
        
        /// <summary>
        ///  KEYBOARD EVENTS
        /// </summary>
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

        /// END EVENTS
        /// START HELPERS

        /// <summary>
        /// Helper functions start from there. All of them below are used
        /// to as helpers for all the events above.
        /// </summary>
        /// 

        /// <summary>
        /// override CreateParams
        /// Used to stop flickering
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        /// <summary>
        /// Function Guess()
        /// @return void
        /// Helper Function used to process the clicked character
        /// </summary>
        private void Guess(char c)
        {
            var State = ( Globals.GUESS) game.UpdateSession(c);
            if (State == Globals.GUESS.SUCCESS)
            {
                // playSound(Hangman.Properties.Resources.correctanswer);

            }
            else if (State == Globals.GUESS.FAIL)
            {
                //playSound(Hangman.Properties.Resources.wronganswer);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Многу ни е жал!\nВие сте обесени.\nПробајте повторно :(");
                MessageBox.Show(sb.ToString(), "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timerRemainingTime.Stop();
                pbGuy.Image = null;
                TimeElapsed = 0;
            }

            lblPogodiZbor.Text = game.Session.EncryptedWord;
            lblPoeni.Text = Convert.ToString(game.GetPoints());
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
        /// Function UpdateTme()
        /// @return bool
        /// Helper Function used to update the time on each timer tick
        /// </summary>
        private void UpdateTime()
        {
            int TimeLeft = Globals.TOTAL_GAME_TIME - TimeElapsed;
            int min = TimeLeft / 60;
            int sec = TimeLeft % 60;
            lblRemainingTime.Text = string.Format("{0:D2}:{1:D2}", min, sec);
        }
        /// <summary>
        /// Function playSound
        /// return void
        /// Helper function for playing sounds
        /// </summary>
        private void playSound(System.IO.Stream wav, bool looping = false)
        {
            SoundPlayer simpleSound = new SoundPlayer(wav);
            if (looping)
            {
                simpleSound.Play();
            }
            else
            {
                simpleSound.PlayLooping();
            }
            
        }
        /// <summary>
        /// Allow access to the panel used for drawing the body
        /// </summary>
        public PictureBox pbGuyBox
        {
            get { return pbGuy; }
            set { pbGuy = value; }
        }

        /// <summary>
        /// Disable buttons on the keyboard
        /// </summary>
        public void disableKeyboardButtons()
        {
            foreach (Control c in pnlKeyboard.Controls)
            {
                if (c.Name != "btnPause")
                {
                    c.Enabled = false;
                    c.BackColor = Color.Gray;
                }
            }
        }
        /// <summary>
        /// Enable buttons on the keyboard
        /// </summary>
        public void enableButtonsKeyboard()
        {
            foreach (Control c in pnlKeyboard.Controls)
            {
                if (c.Name != "btnPause")
                {
                    c.Enabled = true;
                    c.BackColor = Color.SeaGreen;
                }
            }
        }
    }
}
