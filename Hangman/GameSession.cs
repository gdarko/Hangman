using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    /**
     *  Class GameSession
     *  Basically used to process every new word and generate its string 
     *  with underscores
     * 
     *  @authors: 
     *  -Damjan Miloshevski
     *  -Maja Korunoska
     *  -Darko Gjorgjijoski
     */

    public class GameSession
    {
        /**
         * @param string Word
         * Keeps the Word that is generated for this session for guessing
         */
        private string Word;

        /**
         * @param string EncryptedWord
         * Keeps the Word in underscored version that is public for player 
         */
        public string EncryptedWord { get; set; }

        /**
         * @param readonly int BodyParts
         * Keeps the total number of BodyParts in readonly integer variable 
         */
        private readonly int BodyParts = 6;

        /**
         * @param int BodyPartsAdded
         * Keeps the total number of BodyParts Hanged in this session 
         */
        public int BodyPartsAdded { get; set; }

        /**
         * @param int points
         * Keeps the total points scored by the user in this session 
         */
        public int points { get; set; }

        //Constructor
        public GameSession()
        {
            this.Word = RandomWord.getRandom();
            this.EncryptedWord = RandomWord.Encrypt(this.Word);
            this.points = 0;
            this.BodyPartsAdded = 0;
        }

        /**
         * Function isHanged()
         * @return bool
         * Check wherether if the user is hanged, so if BodyParts and
         * BodyPartsAdded are equal means all the body parts of the
         * user are hanged and the user loses the game
         */
        public bool isHanged()
        {
            return this.BodyParts.Equals(this.BodyPartsAdded);
        }

        /**
         * Function isGuessingSuccessful()
         * @return bool
         * Check wherether if the user guessed the word successfuly
         */
        public bool isGuessingSuccessful()
        {
            return this.EncryptedWord.Equals(this.Word);
        }

        /**
         * Function ProcessNewCharacter()
         * @return bool
         * 
         * Saves the underscores indexes from EncryptedWord into the array
         * and check if the characters from Word on those positions are the
         * same with the user input. 
         * If true it increasses the User points and return true, Otherwise it 
         * return false, meaning that body part needs to be hanged.
         */
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
