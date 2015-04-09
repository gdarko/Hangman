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
            }
            else
            {
                MessageBox.Show("Играта не може да започне!");
                this.Close();
               // Application.Exit();
                Environment.Exit(1);
            }
            
        }

        
    }
}
