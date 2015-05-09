using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

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
        public static string[] words =
            new string[] {
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
            "sokak",
            "fakultet",
            "patuvanje",
            "letuvanje",
            "srekja",
            "geografija",
            "zivot",
			"telepatija",
			"student",
			"dozd",
            "hemija",
            "popokateptl",
            "kilimandzaro",
            "avtokefalnost",
            "havarija",
            "inzenerstvo",
            "modernizacija",
            "helikobakterija",
            "energetika",
            "bure-barut",
            "dzimirinka",
            "ajvar",
            "pracka",
            "avokado",
            "seizmologija",
            "hidrometeorologija",
            "lihnidos",
            "astibo",
            "republika",
            "armija",
            "zamok",
            "manastir",
            "zemjotres",
            "sveta-gora",
            "kajmakcalan",
            "nidze",
            "solunska-glava",
            "jakupica",
            "sultan-tepe",
            "carev-vrv",
            "ris",
            "diva-koza",
            "oklop",
            "bazen",
            "otpor",
            "jamajka",
            "golemina",
            "informatika",
            "programiranje",
            "razvoj",
            "industrija",
            "zeleznica",
            "nacionalnost",
            "drzavnost",
            "istorija",
            "golemina",
            "neolit",
            "paleolit",
            "sajonara",
            "glusec",
            "vetrobran",
            "klisura",
            "karpa",
            "zmija",
            "kaval",
            "kanalizacija",
            "vodovod",
            "bunker",
            "tajno",
            "mrak",
            "zimbamve",
            "akonkagva",
            "fidzi",
            "fukusima",
            "nagasaki",
            "cernobil",
            "komunizam",
            "kapitalizam",
            "socijalizam",
            "ropstvo",
            "spijunaza",
            "vselena",
            "aerodrom",
            "destinacija",
            "dalecina",
            "umisla",
            "ubistvo",
            "policija",
            "korab",
            "titov-vrv",
            "istrazuvanje",
            "telefonija",
            "manipulacija",
            "stereo",
            "akustika",
            "studio",
            "stadion",
            "natprevar",
            "sport",
            "covecnost",
            "humanost",
            "civilizacija",
        };
        public static string getRandom()
        {
            Random rnd = new Random();
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
