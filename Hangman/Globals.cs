using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Globals
    {
        public enum GUESS
        {
            HANGED = 1,
            FAIL,
            SUCCESS,
        }

        public enum LEVELS
        {
            EASY = 4,
            NORMAL,
            HARD,
        }

    }
}
