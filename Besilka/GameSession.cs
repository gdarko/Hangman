using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besilka
{
    public class GameSession
    {
        private string Word;
        public string EncryptedWord { get; set; }
        readonly int BodyParts = 5;
        public int BodyPartsAdded { get; set; }
        public int points {get; set;}

        public GameSession()
        {
            this.Word = RandomWord.getRandom();
            this.EncryptedWord = RandomWord.Encrypt(this.Word);
            points = 0;
            BodyPartsAdded = 0;
        }

        public bool isHanged()
        {
            return BodyParts == BodyPartsAdded;
        }

        public bool ProcessNewCharacter(Char a)
        {
            if (Word.Contains(a))
            {
                points++;
                return true;
            }
            BodyPartsAdded++;
            return false;
        }
    }
}
