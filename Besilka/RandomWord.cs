using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Besilka
{
    public static class RandomWord
    {
       
  
        public static string [] words = new string[] {"Mecka",
                "Kucka",
                "Kamion",
                "Prikolka",
                "Lubenica",
                "Lubov"
        };

        public static string getRandom()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, words.Length-1);
            return words[index];
        }
    }
}
