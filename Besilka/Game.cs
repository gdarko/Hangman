using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besilka
{
    public class Game
    {
        public string Zbor { get; set; }
        public Player player { get; set; }

        public Game(Player player)
        {
            this.player = player;
            this.Zbor = RandomWord.getRandom();
        }
    }
}
