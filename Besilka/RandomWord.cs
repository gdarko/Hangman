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
       
  
        public static string [] words = new string[] {
                "mecka",
                "kucka",
                "kamion",
                "prikolka",
                "lubenica",
                "ljubov",
                "jorgan",
                "avtomobil",
                "kompjuter",
                "video",
                "tablet",
                "devojka",
                "momce",
                "zgrada",
                "telefon",
                "tepih",
                "baterija",
                "sokak"
        };

        public static string getRandom()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, words.Length-1);
            return words[index];
        }

        public static string Encrypt(string s)
        {
            int lenght = s.Length;
            int totalUnderscores = lenght / 3;
            int index = 0;

            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(s);

            for (int i = 0; i < totalUnderscores; i++)
            {

                index = rnd.Next(0, lenght - 1);
                sb[index] = '_';

            }

            return sb.ToString();

        }
    }
}
