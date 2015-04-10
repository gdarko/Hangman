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
    /**
     *  @authors: 
     *  -Damjan Miloshevski
     *  -Maja Korunoska
     *  -Darko Gjorgjijoski
     */

    public partial class NewGame : Form
    {
        public Game result { get; set; }

        public NewGame()
        {
            InitializeComponent();
        }
        private void btnPocetok_Click(object sender, EventArgs e)
        {
            string FirstName = tbFirstName.Text;
            string LastName = tbLastName.Text;
            string NickName = tbNickName.Text;
            result = new Game(new Player(FirstName, LastName, NickName, 0));
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

    }
}
