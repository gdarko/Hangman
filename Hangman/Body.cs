using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman
{
    public class Body
    {
        //private HangmanForm refmain;
        public Graphics g;
        
        public bool Head { get; set; }
        public bool Spinal { get; set; }
        public bool LeftHand { get; set; }
        public bool RightHand { get; set; }
        public bool LeftLeg { get; set; }
        public bool RightLeg { get; set; }

        protected PictureBox pb { get; set; }


        public Body(HangmanForm main, bool UseGraphics = true)
        {
            ResetBody();
            pb = main.pbGuyBox;
        }

        private void addHead()
        {
            drawImg(Hangman.Properties.Resources.head);
            Head = true;
        }

        private void addSpinal()
        {
            drawImg(Hangman.Properties.Resources.body);
            Spinal = true;
        }

        private void addLeftHand()
        {
            drawImg(Hangman.Properties.Resources.left_hand);
            LeftHand = true;
        }

        private void addRightHand()
        {
            drawImg(Hangman.Properties.Resources.right_hand);
            RightHand = true;
        }

        private void addLeftLeg()
        {
            drawImg(Hangman.Properties.Resources.left_leg);
            LeftLeg = true;
        }

        private void addRightLeg()
        {
            drawImg(Hangman.Properties.Resources.hanged);
            RightLeg = true;
        }

        private void ResetBody()
        {
            Head = false;
            Spinal = false;
            LeftHand = false;
            RightHand = false;
            LeftLeg = false;
            RightLeg = false;
        }

        public void Hang()
        {
            if (!Head)
            {
                addHead();
            }
            else if (!Spinal)
            {
                addSpinal();
            }
            else if (!LeftHand)
            {
               addLeftHand(); 
            }
            else if (!RightHand)
            {
                addRightHand();  
            }

            else if (!LeftLeg)
            {
                addLeftLeg();
            }
            else if (!RightLeg)
            {
                addRightLeg();
            }
            else
            {
                return;
            }
        }

        void drawImg(Bitmap Res)
        {
            pb.Image = new Bitmap(Res);
        }


    }

    
}
