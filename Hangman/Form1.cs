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
        /// Database connection
        /// </summary>
        Hmdb db;

        /// <summary>
        /// Timer for the game
        /// </summary>
        DateTime EndOfTime;

        public HangmanForm()
        {
            InitializeComponent();
            this.db = new Hmdb();
            NewGame window = new NewGame();

            // Show the NewGame form on initialization and get the results from it
            if (window.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.game = new Game(window.result, this);
                tbIme.Text = game.Player.FirstName;
                tbPrekar.Text = game.Player.NickName;
                tbPrezime.Text = game.Player.LastName;
                lblPogodiZbor.Text = game.Session.EncryptedWord;
            }
            else
            {
                MessageBox.Show("Играта не може да започне!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(1);
            }            
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;  
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
            HighScores window = new HighScores();
            window.ShowDialog();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            formBesilka_FormClosing(sender, null);
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
            Application.Exit();
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
            bool state = this.db.insertResult(firstname, nickname, lastname, points);
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
            lblRemainingTime.Text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            if (ts.TotalMilliseconds < 0)
            {
                Timer t = sender as Timer;
                t.Enabled = false;
                MessageBox.Show("Вашето време истече!", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formBesilka_FormClosing(sender, null);
            }
        }
        private void startTimer()
        {
            EndOfTime = DateTime.Now.AddMinutes(5);
            timerRemainingTime = new Timer() { Enabled = true };
            timerRemainingTime.Tick += new EventHandler(timerRemainingTime_Tick);
        }

        private void HangmanForm_Load(object sender, EventArgs e)
        {
            startTimer();
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
    }
}
