using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{

    /// <summary>
    /// Used to represent the Game that user starts once
    /// the application is executed
    /// 
    /// @authors:
    /// -Damjan Miloshevski
    /// -Maja Korunoska
    /// -Darko Gjorgjijoski
    /// </summary>
    public class Game : HMController
    {

        public GameSession Session { get; set; }
        public Player Player { get; set; }
        public Hmdb DB { get; set; }

        public Game(Player player, HangmanForm main) : base (main)
        {
            this.Player = player;
            New();
            this.DB = new Hmdb();
        }

        public void New()
        {
            this.Session = new GameSession(MainForm);
        }

        public bool GameIsStared()
        {
            return Session != null;
        }

        public void AddPoints()
        {
            this.Player.Points += this.Session.points;
        }

        public int GetPoints()
        {
            return this.Player.Points;
        }

        public int UpdateSession(Char a)
        {
            if (Session.isHanged())
            {
                New();
                return (int)Globals.GUESS.HANGED;
            }
            else
            {
                if (! Session.Guess(a) )
                {

                    Session.Body.Hang();
                    return (int)Globals.GUESS.FAIL;
                } 
                else
                {
                    if (Session.isGuessingSuccessful())
                    {
                        AddPoints();
                        New();
                    }
                    
                    return (int)Globals.GUESS.SUCCESS;
                }
                
            }
        }
    }
}
