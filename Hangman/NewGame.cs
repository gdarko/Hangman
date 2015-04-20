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
        public Player result { get; set; }

        public NewGame()
        {
            InitializeComponent();
        }
        private void btnPocetok_Click(object sender, EventArgs e)
        {
            string FirstName = tbFirstName.Text;
            string LastName = tbLastName.Text;
            string NickName = tbNickName.Text;
            result = new Player(FirstName, LastName, NickName, 0);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
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
                errorName.SetError(tbFirstName, "Ве молиме внесете име!");
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
                errorSurname.SetError(tbLastName, "Ве молиме внесете презиме!");
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
                errorNickname.SetError(tbNickName, "Поинтересно е со прекар! :)");
            }
        }
    }
}
