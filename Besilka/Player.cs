using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besilka
{
    /**
     *  @authors: 
     *  -Damjan Miloshevski
     *  -Maja Korunoska
     *  -Darko Gjorgjijoski
     */

    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int Points { get; set; }

        public Player(string FirstName, string LastName, string NickName, int Points)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NickName = NickName;
            this.Points = Points;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} \"{2}\" - {3}", FirstName, NickName, LastName, Points);
        }
    }
}
