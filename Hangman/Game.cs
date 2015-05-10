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
    public class Game
    {
        public HangmanForm MainForm { get; set; }
        public GameSession Session { get; set; }
        public Player Player { get; set; }
        public Hmdb DB { get; set; }
        public HmOptions Options {get; set;}
        public Globals.STATE isRunning { get; set; }
        

        public Game(Player player, HangmanForm main, HmOptions options = null)
        {
            this.MainForm = main;
            this.Options = options;
            this.Player = player;
            New();
            this.isRunning = Globals.STATE.RUNNING;
            this.DB = new Hmdb();
        }

        public void Restart()
        {
            New();
            this.Player.Points = 0;
        }

        public void New()
        {
            this.Session = new GameSession(MainForm, Options.Level);
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
