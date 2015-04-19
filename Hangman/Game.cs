using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    /**
     *  Game class
     *  Used to represent the Game that user starts once 
     *  the application is executed
     * 
     *  @authors: 
     *  -Damjan Miloshevski
     *  -Maja Korunoska
     *  -Darko Gjorgjijoski
     */

    public class Game
    {
        public GameSession Session { get; set; }
        public Player Player { get; set; }

        public Game(Player player)
        {
            this.Player = player;
            this.Session = new GameSession();
        }

        public void New()
        {
            this.Session = new GameSession();
        }

        public void AddPoint()
        {
            this.Player.Points += this.Session.points;
        }

        public int GetPoints()
        {
            return this.Player.Points;
        }
    }
}
