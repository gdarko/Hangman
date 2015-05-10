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
    /// <summary>
    ///  @authors: 
    ///  -Damjan Miloshevski
    ///  -Maja Korunoska
    ///  -Darko Gjorgjijoski
    /// </summary>

    public partial class NewGame : Form
    {
        public Player player { get; set; }
        public HmOptions options  { get; set; }

        public NewGame()
        {
            InitializeComponent();
        }
        private void btnPocetok_Click(object sender, EventArgs e)
        {
            if(cbLevels.SelectedIndex != -1)
            {
                string FirstName = tbFirstName.Text;
                string LastName = tbLastName.Text;
                string NickName = tbNickName.Text;
                Globals.LEVELS Level = (Globals.LEVELS)cbLevels.SelectedIndex + 1;

                options = new HmOptions(Level);

                player = new Player(FirstName, LastName, NickName, 0);

                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("You must choose a level before start", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                errorName.SetError(tbFirstName, null);
            }
            else
            {
                e.Cancel = true;
                errorName.SetError(tbFirstName, "Please enter name!");
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                errorSurname.SetError(tbLastName, null);
            }
            else
            {
                e.Cancel = true;
                errorSurname.SetError(tbLastName, "Please enter last name!");
            }
        }

        private void tbNickName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNickName.Text))
            {
                errorNickname.SetError(tbNickName, null);
            }
            else
            {
                e.Cancel = true;
                errorNickname.SetError(tbNickName, "Please enter nick name!");
            }
        }
    }
}
