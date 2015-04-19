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
    /**
     *  Main Form
     * 
     *  @authors: 
     *  -Damjan Miloshevski
     *  -Maja Korunoska
     *  -Darko Gjorgjijoski
     */

    public partial class HangmanForm : Form
    {
        /**
         * @param Game game
         * The game used to keep the Player info,  and GameSession
         */
        Game game;

        /**
         * @param Hmdb db
         * Keep a connection to the database
         */
        Hmdb db;

        /**
         * @return void
         * Makes the body parts invisible on initialization
         */
        public void UnloadBody()
        {
            pbBody.Visible = false;
            pbHead.Visible = false;
            pbLeftHand.Visible = false;
            pbLeftLeg.Visible = false;
            pbRightHand.Visible = false;
            pbRightLeg.Visible = false;
        }

        // Constructor
        public HangmanForm()
        {
            InitializeComponent();
            UnloadBody();

            //Database initialization
            this.db = new Hmdb();

            //NewGame instance used to show the NewGame form(window)
            NewGame window = new NewGame();

            // Show the NewGame form on initialization and get the results from it
            if (window.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.game = window.result;
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

        /**
         * Function btnCheck_Click()
         * @return void
         * btnCheck event
         */
        private void btnCheck_Click(object sender, EventArgs e)
        {
            char c = tbCharacter.Text[0];
            bool result = game.Session.ProcessNewCharacter(c);
            UpdateSession(result);
            
        }

        /**
         * Function btnResults_Click()
         * @return void
         * btnResults event
         */
        private void btnResults_Click(object sender, EventArgs e)
        {
            HighScores window = new HighScores();

            window.ShowDialog();
        }

        /**
         * Function btnClose_Click()
         * @return void
         * btnClose event
         */
        private void btnClose_Click(object sender, EventArgs e)
        {
            formBesilka_FormClosing(sender, null);
        }

        /**
         * Function formBesilka_FormClosing()
         * @return void
         * FormClosing event
         */
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
                    MessageBox.Show("Настана грешка при зачувување на вашиот резултат!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Environment.Exit(1);

        }

        /**
         * Function dbSaveResult()
         * @return bool
         * Ccalled the user prompt to save the result in the 
         * database and returns bool if success
         */
        private bool dbSaveResult()
        {
            string firstname = game.Player.FirstName;
            string nickname = game.Player.NickName;
            string lastname = game.Player.LastName;
            int points = game.Player.Points;
            bool state = this.db.insertResult(firstname, nickname, lastname, points);
            return state;

        }

        /**
         * Function UpdatePoints()
         * @return void
         * UpdatePoints() is called when correct letter is entered
         * Updates the points to the lblPoeni label
         */
        private void UpdatePoints()
        {
            int CurrentPoints = Convert.ToInt32(lblPoeni.Text);
            int NewPoints = CurrentPoints + (int)game.Session.points;
            lblPoeni.Text = Convert.ToString(NewPoints);
        }

        /**
         * Function UpdateSession(bool)
         * @params bool result
         * @return void
         * Called once the user enter a letter in the text box and after the
         * letter is processed by the GameSession.ProccessNewLetter()
         * UpdateSession receives GameSession.ProccessNewLetter() result as parameter
         *
         * Few cases are convered:
         * 
         * If the Player is hanged
         * Otherwise
         *  Check if wrong letter is entered using the "result" parameter
         *  Check if the session is finished successfully.(Found match)
         *  or the Player is still in the session and guess the next letter
         */
        private void UpdateSession(bool result)
        {
            if (game.Session.isHanged())
            {
                UnloadBody();
                tbCharacter.Text = "";
                game.New();
                lblPogodiZbor.Text = game.Session.EncryptedWord;
                lblPoeni.Text = Convert.ToString(game.Session.points);
                return;
            }
            else
            {
                if (!result)   // Vnesol gresen karakter
                {
                    UpdateBody();
                }
                else if (game.Session.isGuessingSuccessful())
                {
                    tbCharacter.Text = "";
                    UpdatePoints();
                    UnloadBody();
                    game.New();
                    lblPogodiZbor.Text = game.Session.EncryptedWord;
                }
                else
                {
                    UpdatePoints();
                    lblPogodiZbor.Text = game.Session.EncryptedWord;

                }
            }
        }

        /**
         * Function UpdateBody()
         * @return void
         * Called when the Player failed to guess the letter/word and on
         * every fail it Hang his body part by part
         */
        private void UpdateBody()
        {

            switch (game.Session.BodyPartsAdded)
            {
                case 1:
                    pbHead.Visible = true;
                    break;
                case 2:
                    pbBody.Visible = true;
                    break;
                case 3:
                    pbLeftHand.Visible = true;
                    break;
                case 4:
                    pbRightHand.Visible = true;
                    break;
                case 5:
                    pbLeftLeg.Visible = true;
                    break;
                case 6:
                    pbRightLeg.Visible = true;
                    break;
            }
        }
        
    }
}
