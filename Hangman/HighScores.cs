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
     *  Highscores Form
     *  Used to display the highscore results from database
     *  
     * @Authors
     *  -Damjan Miloshevski
     *  -Maja Korunoska
     *  -Darko Gjorgjijoski
     *
     */

    public partial class HighScores : Form
    {

        private Hmdb _db { get; set; }

        public HighScores(Hmdb db = null)
        {
            InitializeComponent();

            this._db = db;

            List<Player> Players = _db.getRangList();

            foreach (Player player in Players)
            {
                lbHighscores.Items.Add(player);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
