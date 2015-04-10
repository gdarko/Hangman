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

    public class GameSession
    {
        private string Word;
        public string EncryptedWord { get; set; }
        readonly int BodyParts = 6;
        public int BodyPartsAdded { get; set; }
        public int points {get; set;}

        public GameSession()
        {
            this.Word = RandomWord.getRandom();
            this.EncryptedWord = RandomWord.Encrypt(this.Word);
            this.points = 0;
            this.BodyPartsAdded = 0;
        }

        public bool isHanged()
        {
            return this.BodyParts.Equals(this.BodyPartsAdded);
        }

        public bool isFinishedSuccessfully()
        {
            return this.EncryptedWord.Equals(this.Word);
        }

        public bool ProcessNewCharacter(Char a)
        {
            int [] indexes = new int[10]; 
            for(int i = 0, j=0; i<EncryptedWord.Length; i++)
            {
                if(EncryptedWord[i] == '_')
                {
                    indexes[j++] = i;
                }
            }

            StringBuilder ew = new StringBuilder(EncryptedWord);
            bool ExitsInEncrypted = false;
            for (int i = 0; i < indexes.Length; i++)
            {
                if (Word[indexes[i]] == a)
                {
                    ew[indexes[i]] = a;
                    ExitsInEncrypted = true;
                    break;
                }
            }

            if (!ExitsInEncrypted)
            {
                this.BodyPartsAdded = this.BodyPartsAdded + 1;
                return false;
            }

            this.points = this.points + 1;
            this.EncryptedWord = ew.ToString();

            return true;
            
        }
    }
}
