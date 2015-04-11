using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Hangman
{
    public class Hmdb
    {
        public SQLiteConnection Db { get; set; }

        public Hmdb()
        {
            this.Db = new SQLiteConnection("Data Source=Highscores.s3db;Version=3;");
            this.Db.Open();
        }

        public List<Player> getRangList()
        {
            string sql = "select * from scores order by points desc";
            SQLiteCommand command = new SQLiteCommand(sql, this.Db);
            SQLiteDataReader reader = command.ExecuteReader();
            List<Player> players = new List<Player>();
            while (reader.Read())
            {
                players.Add(new Player(Convert.ToString(reader["firstname"]), Convert.ToString(reader["lastname"]), Convert.ToString(reader["nickname"]), Convert.ToInt32(reader["points"])));
            }
            return players;
        }

        public bool insertResult(string fname, string nname, string lname, int pts)
        {
            SQLiteCommand command = new SQLiteCommand("insert into scores (firstname, nickname, lastname, points) values (@firstname, @nickname, @lastname,@points)", this.Db);
            command.Parameters.AddWithValue("@firstname", fname);
            command.Parameters.AddWithValue("@nickname", nname);
            command.Parameters.AddWithValue("@lastname", lname);
            command.Parameters.AddWithValue("@points", pts);
            int state = command.ExecuteNonQuery();
            return ( state > 0) ? true:false;  // vrati tocno ako uspesno dodaden rezultatot vo bazata na podatoci
        }

        public void Close()
        {
            this.Db.Close();
        }
    }
}
