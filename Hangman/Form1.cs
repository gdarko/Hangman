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
        DateTime EndOfTime;

        public HangmanForm()
        {
            InitializeComponent();
            NewGame window = new NewGame();
            lblPogodiZbor.Visible = false;

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
                MessageBox.Show("Многу ни е жал!\nВие сте обесени.\nПробајте повторно :(", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCharacter.Text = null;
                startTimer();
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
            DialogResult result = MessageBox.Show("Дали сакате да го зачувате резултатот во базата?", "Резултат", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
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
            TimeSpan ts = EndOfTime.Subtract(DateTime.Now);
            lblRemainingTime.Text = string.Format("{0:D2}:{1:D2}", ts.Minutes, ts.Seconds);
            if (ts.TotalMilliseconds < 0)
            {
                Timer t = sender as Timer;
                t.Enabled = false;
                MessageBox.Show("Вашето време истече!", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formBesilka_FormClosing(sender, null);
                btnCheck.Enabled = false;
                btnPause.Enabled = false;
                btnHelp.Enabled = false;
                label6.Visible = false;
                lblRemainingTime.Visible = false;
                tbCharacter.ReadOnly = true;
            }
        }
        private void startTimer()
        {
            EndOfTime = DateTime.Now.AddMinutes(1);
            timerRemainingTime = new Timer() { Enabled = true };
            timerRemainingTime.Tick += new EventHandler(timerRemainingTime_Tick);
            if (EndOfTime.Second == 0 && EndOfTime.Minute == 0)
            {
                btnResults.Enabled = true;
            }
        }

        private void HangmanForm_Load(object sender, EventArgs e)
        {
            btnStartGame.Focus();
        }
        private bool checkCharacter(string str)
        {//checks the value of the character of the user input
            if (str.Length != 1) return false;
            else if (string.IsNullOrWhiteSpace(str)) return false;
            foreach (object obj in str)
            {
                Char c = Convert.ToChar(obj);
                if (!Char.IsLetter(c)) return false;
            }
            return true;
        }
        private void tbCharacter_Validating(object sender, CancelEventArgs e)
        {
            if (checkCharacter(tbCharacter.Text))
            {
                errorInput.SetError(tbCharacter, null);
            }
            else
            {
                e.Cancel = true;
                errorInput.SetError(tbCharacter, "Внесете една буква!");
            }
        }

        private void излезToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сте сигурни?", "Излези?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response != DialogResult.No)
            {
                Application.Exit();
            }
            else return;
        }

        private void помошToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructions h = new Instructions();
            h.ShowDialog();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (EndOfTime.Minute != 0 && EndOfTime.Second != 0)
            {
                DialogResult response = MessageBox.Show("Тековната игра сеуште трае!", "Нова игра!?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    DialogResult re = MessageBox.Show("Со почнување на нова игра моментално освоените поени ви се бришат!!",
                        "Потврди?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        startTimer();
                    }
                    else return;
                }
                else return;
            }
            else
            {
                startTimer();
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
        }

        private void листаСоРезултатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (game.DB != null)
            {
                if (EndOfTime.Second != 0 && EndOfTime.Minute != 0)
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
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timerRemainingTime.Start();
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
    }
}
