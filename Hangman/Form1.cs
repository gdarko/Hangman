﻿using System;
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
     *  @authors: 
     *  -Damjan Miloshevski
     *  -Maja Korunoska
     *  -Darko Gjorgjijoski
     */

    public partial class formBesilka : Form
    {
        Game game;
        Hmdb db;

        public void UnloadBody()
        {
            pbBody.Visible = false;
            pbHead.Visible = false;
            pbLeftHand.Visible = false;
            pbLeftLeg.Visible = false;
            pbRightHand.Visible = false;
            pbRightLeg.Visible = false;
        }

        public formBesilka()
        {
            InitializeComponent();

            this.db = new Hmdb();

            UnloadBody();

            NewGame window = new NewGame();

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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            char c = tbCharacter.Text[0];
            bool result = game.Session.ProcessNewCharacter(c);
            UpdateSession(result);
            
        }

        private void UpdateSession(bool result)
        {
            if (game.Session.isHanged())
            {
                UnloadBody();
                tbCharacter.Text = "";
                game.Session = new GameSession();
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
                else if(game.Session.isFinishedSuccessfully())
                {
                    tbCharacter.Text = "";
                    UpdatePoints();
                    UnloadBody();
                    game.Session = new GameSession();
                    lblPogodiZbor.Text = game.Session.EncryptedWord;
                }
                else
                {
                    UpdatePoints();
                    lblPogodiZbor.Text = game.Session.EncryptedWord;
                    
                }
            }
        }

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

        private void UpdatePoints()
        {
              int CurrentPoints = Convert.ToInt32(lblPoeni.Text);
              int NewPoints = CurrentPoints + (int)game.Session.points;
              lblPoeni.Text = Convert.ToString(NewPoints);
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            HighScores window = new HighScores();

            window.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
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
            else
            {
                Application.Exit();
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
                    MessageBox.Show("Настана грешка при зачувување на вашиот резултат!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Environment.Exit(1);
            }
            else
            {
                Environment.Exit(1);
            }

        }

        private bool dbSaveResult()
        {
            string firstname = game.Player.FirstName;
            string nickname = game.Player.NickName;
            string lastname = game.Player.LastName;
            int points = game.Player.Points;
            bool state = this.db.insertResult(firstname, nickname, lastname, points);
            return state;

        }
        
    }
}
