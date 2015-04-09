using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besilka
{
    public class Game
    {

        public GameSession Session { get; set; }
        public Player Player { get; set; }

        public Game(Player player)
        {
            this.Player = player;
            this.Session = new GameSession();
        }


    }
}
