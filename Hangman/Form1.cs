using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private static readonly int TIME = 300;//300 sekundi = 5 minuti
        private int TimeElapsed;

        public HangmanForm()
        {
            InitializeComponent();
            NewGame window = new NewGame();
            lblPogodiZbor.Visible = false;
            easyToolStripMenuItem.Checked = true;

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


        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;
            //gi validira site kontroli i ako e se vo red prodolzuva ako ne ne, ova go pravam za da sprecam exception...
            char c = tbCharacter.Text[0];

            int State = game.UpdateSession(c);

            if (State == Globals.HANGED)
            {
                Invalidate(true);
                StringBuilder sb = new StringBuilder();
                sb.Append("Многу ни е жал!\nВие сте обесени.\nПробајте повторно :(");
                MessageBox.Show(sb.ToString(),"Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCharacter.Text = null;
                timerRemainingTime.Stop();
                TimeElapsed = 0;
            }

            // Ke se koristat po potreba
            if (State == Globals.GUESS_SUCCESS)
            {

            }

            if (State == Globals.GUESS_NOT_SUCCESS)
            {

            }
            lblPogodiZbor.Text = game.Session.EncryptedWord;
            lblPoeni.Text = Convert.ToString(game.GetPoints());
            tbCharacter.Text = null;
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
                btnPause.Enabled = false;
                btnCheck.Enabled = false;
                btnHelp.Enabled = false;
                lblPogodiZbor.Visible = false;
                tbCharacter.ReadOnly = true;
                btnContinue.Enabled = true;
                btnContinue.ForeColor = Color.White;
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
        public Panel BodyPanel
        {
            get { return pnlBody; }
            set { pnlBody = value; }
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
                btnCheck.Enabled = false;
                btnPause.Enabled = false;
                btnHelp.Enabled = false;
                label6.Visible = false;
                lblRemainingTime.Visible = false;
                tbCharacter.ReadOnly = true;
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

        private void HangmanForm_Load(object sender, EventArgs e)
        {
            btnStartGame.Focus();
        }
        private bool checkCharacter(string str)
        {//checks the value of the character of the user input
            if (str.Length != 1) return false;
            foreach (object obj in str)
            {
                Char c = Convert.ToChar(obj);
                if (!Char.IsLetter(c)) return false;
            }
            return true;
        }
        private void tbCharacter_Validating(object sender, CancelEventArgs e)
        {
            if (!checkCharacter(tbCharacter.Text))
            {
                DialogResult res = MessageBox.Show("Невалиден влез!\n Hint: Внесете една буква!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Cancel = true;
                tbCharacter.Text = null;
                tbCharacter.Focus();
                if (res == DialogResult.OK)
                {
                    e.Cancel = false;
                }
            }
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
                UpdateTime();
                timerRemainingTime.Start();
                btnCheck.Enabled = true;
                btnPause.Enabled = true;
                btnHelp.Enabled = true;
                label6.Visible = true;
                lblPogodiZbor.Visible = true;
                lblRemainingTime.Visible = true;
                tbCharacter.ReadOnly = false;
                btnCheck.ForeColor = Color.White;
                btnPause.ForeColor = Color.White;
                btnHelp.ForeColor = Color.White;
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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timerRemainingTime.Start();
            timerRemainingTime.Enabled = true;
            lblPogodiZbor.Visible = true;
            btnResults.Enabled = false;
            btnContinue.Enabled = false;
            btnPause.Enabled = false;
            btnPause.Enabled = true;
            btnStartGame.Enabled = true;
            btnCheck.Enabled = true;
            btnHelp.Enabled = true;
            tbCharacter.ReadOnly = false;
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
    }
}
