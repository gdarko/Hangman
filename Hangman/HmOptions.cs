using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class HmOptions
    {
        public Globals.LEVELS Level { get; set; }

        public HmOptions(Globals.LEVELS Level)
        {
            this.Level = Level;
        }
    }
}
