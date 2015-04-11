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
    public partial class HighScores : Form
    {

        Hmdb db;

        public HighScores()
        {
            InitializeComponent();
            db = new Hmdb();

            List<Player> Players = db.getRangList();

            foreach (Player player in Players)
            {
                lbHighscores.Items.Add(player);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            db.Close();
            Close();
        }
    }
}
