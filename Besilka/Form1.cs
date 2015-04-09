using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Besilka
{
    public partial class formBesilka : Form
    {
        Game game;

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

            UnloadBody();

            NewGame window = new NewGame();

            if (window.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.game = window.result;
                tbIme.Text = game.Player.FirstName;
                tbPrekar.Text = game.Player.NickName;
                tbPrezime.Text = game.Player.FirstName;

                lblPogodiZbor.Text = game.Session.EncryptedWord as string;
            }
            else
            {
                MessageBox.Show("Играта не може да започне!");
                this.Close();
               // Application.Exit();
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
                game.Session = new GameSession();
                return;
            }
            else
            {
                if (!result)   // Vnesol gresen karakter
                {
                    UpdateBody();
                }
                else
                {
                    UpdatePoints();
                    
                }
            }
        }

        private void UpdateBody()
        {
            int NumberBodyPartsVisableCurrently = game.Session.BodyPartsAdded;

            switch (NumberBodyPartsVisableCurrently)
            {
                case 0:
                    pbHead.Visible = true;
                    break;
                case 1:
                    pbBody.Visible = true;
                    break;
                case 2:
                    pbLeftHand.Visible = true;
                    break;
                case 3:
                    pbRightHand.Visible = true;
                    break;
                case 4:
                    pbLeftLeg.Visible = true;
                    break;
                case 5:
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



        
    }
}
