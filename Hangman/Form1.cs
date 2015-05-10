using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

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
            InitGame();
        }

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
            if (game.isRunning == Globals.STATE.RUNNING)
            {
                timerRemainingTime.Start();
                timerRemainingTime.Enabled = true;
                btnStartGame.Visible = true;
                lblPogodiZbor.Visible = true;
                btnStartGame.Visible = true;
                btnPause.Text = "Pause";
                enableButtonsKeyboard();
                game.isRunning = Globals.STATE.PAUSED;
            }
            else
            {

                DialogResult response = MessageBox.Show("The game is paused!", "Pause game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timerRemainingTime.Stop();
                timerRemainingTime.Enabled = false;
                btnStartGame.Visible = false;
                lblPogodiZbor.Visible = false;
                btnStartGame.Visible = false;
                btnPause.Text = "Continue";
                disableKeyboardButtons();
                game.isRunning = Globals.STATE.RUNNING;
            }
            
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(game.isRunning == Globals.STATE.RUNNING)
            {
                game.Restart();
                TimeElapsed = 0;
                timerRemainingTime.Start();
                timerRemainingTime.Enabled = true;
                lblPogodiZbor.Visible = true;
                lblRemainingTime.Visible = true;
                btnPause.Enabled = true;
                btnStartGame.Text = "Stop";
                btnPause.Text = "Pause";
                lblPogodiZbor.Text = game.Session.EncryptedWord;
                enableButtonsKeyboard();
                game.isRunning = Globals.STATE.STOPPED;
            }
            else
            {
                timerRemainingTime.Stop();
                timerRemainingTime.Enabled = false;
                lblPogodiZbor.Visible = false;
                lblRemainingTime.Visible = false;
                btnPause.Enabled = false;
                btnStartGame.Text = "Start";
                btnPause.Text = "Pause";
                lblPogodiZbor.Text = game.Session.EncryptedWord;
                disableKeyboardButtons();
                game.isRunning = Globals.STATE.RUNNING;
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
                btnPause.Enabled = false;
                label6.Visible = false;
                lblRemainingTime.Visible = false;
                timerRemainingTime.Enabled = false;
                timerRemainingTime.Stop();
                btnStartGame.Visible = true;

                if(MessageBox.Show("Your time elapsed! Please choose click Yes if you want to start new game", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    InitGame();
                }
                else
                {
                    MessageBox.Show("Game can not be started!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(1);
                }
            }

            UpdateTime();
        }

        /// <summary>
        ///  MENU TOOLSTRIP EVENTS
        /// </summary>
        private void listresTSMI_Click(object sender, EventArgs e)
        {
            HighScores window = new HighScores(game.DB);
            window.ShowDialog();
        }
        private void closeTSMI_Click(object sender, EventArgs e)
        {
            if (TimeElapsed != 0)
            {
                DialogResult result = MessageBox.Show("The game is still not finished. Do you want to continue playing?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            DialogResult res = MessageBox.Show("Are you sure?", "New Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                TimeElapsed = 0;
                UpdateTime();
            }
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

        private void optionTSMI_Click(object sender, EventArgs e)
        {
            Options o = new Options();
            if (DialogResult.OK == o.ShowDialog())
            {
                game.Options.Level = o.Level;
                MessageBox.Show("Changes done!");
            }
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
                cp.ExStyle |= 0x02000000;
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
                playSound(Hangman.Properties.Resources.correctanswer, false);

            }
            else if (State == Globals.GUESS.FAIL)
            {
                playSound(Hangman.Properties.Resources.wronganswer, false);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("We are sorry!\nYou are hanged.\nPlease try again");
                MessageBox.Show(sb.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            return game.DB.insertResult(firstname, nickname, lastname, points);
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
                simpleSound.PlaySync();
            }
            else
            {
                simpleSound.PlaySync();
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

        public void InitGame()
        {
            lblPogodiZbor.Visible = false;
            easyToolStripMenuItem.Checked = true;
            disableKeyboardButtons();
            btnStartGame.Text = "Start";
            NewGame window = new NewGame();
            // Show the NewGame form on initialization and get the results from it
            if (window.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                game = new Game(window.player, this, window.options);
                tbIme.Text = game.Player.FirstName;
                tbPrekar.Text = game.Player.NickName;
                tbPrezime.Text = game.Player.LastName;
                lblPogodiZbor.Text = game.Session.EncryptedWord;
            }
            else
            {
                MessageBox.Show("Game can not be started!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(1);
            }
        }

    
    }
}
