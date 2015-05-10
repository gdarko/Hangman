using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public static class Globals
    {
        public enum GUESS
        {
            HANGED = 1,
            FAIL,
            SUCCESS,
        }

        public enum LEVELS
        {
            EASY = 1,
            NORMAL,
            HARD,
        }

        public static readonly int TOTAL_GAME_TIME = 240; //240 sekundi = 4 minuti

    }
}
