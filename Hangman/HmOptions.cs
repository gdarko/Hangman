using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class HmOptions
    {
        public bool EnableSong { get; set; }
        public Globals.LEVELS Level { get; set; }

        public HmOptions(Globals.LEVELS Level, bool EnableSong = true)
        {
            this.EnableSong = EnableSong;
            this.Level = Level;
        }
    }
}
