using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace Hangman
{
    /// <summary>
    ///  @authors: 
    ///  -Damjan Miloshevski
    ///  -Maja Korunoska
    ///  -Darko Gjorgjijoski
    /// </summary>

    public static class RandomWord
    {

        public static string [] ReadXML(string s)
        {   
            var WordsArr = XDocument.Parse(s);
            var array = WordsArr.Descendants("Word").Select(x => (string)x).ToArray();
            return array;
        }

        public static string getRandom(Globals.LEVELS L)
        {
            string wrdLoc = "";
            if (L == Globals.LEVELS.EASY)
            {
                wrdLoc = Hangman.Properties.Resources.Easy;
            }
            else if(L == Globals.LEVELS.NORMAL)
            {
                wrdLoc = Hangman.Properties.Resources.Medium;
            }
            else
            {
                wrdLoc = Hangman.Properties.Resources.Hard;
            }
            Random rnd = new Random();
            string[] words = ReadXML(wrdLoc);
            int index = rnd.Next(0, words.Length - 1);
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
