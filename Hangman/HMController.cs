using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public class HMController
    {
        public HangmanForm MainForm { get; set; }

        public HMController(HangmanForm f)
        {
            this.MainForm = f;
        }
    }
}
