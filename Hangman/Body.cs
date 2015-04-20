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

        public bool useGraphics;

        private Pen pen { set; get; }


        public Body(HangmanForm main, bool UseGraphics = true)
        {
            this.useGraphics = UseGraphics;
            pen = new Pen(Color.Black, 5);
            g = main.BodyPanel.CreateGraphics();
            ResetBody();
        }

        private void addHead()
        {
            Head = true;

            if (useGraphics == true)
            {
                g.DrawEllipse(pen, 0, 0, 100, 100);
            }
            else
            {
                var bmp = new Bitmap(Properties.Resources.head);
                g.DrawImage(bmp, 0, 0, 100, 100);

            }
        }

        private void addSpinal()
        {
            Spinal = true;
            if (useGraphics == true)
            {
                g.DrawLine(pen, 50, 100, 50, 200);
            }
            else
            {
                var bmp = new Bitmap(Properties.Resources.body);
                g.DrawImage(bmp, 50, 100, 50, 200);

            }
        }

        private void addLeftHand()
        {
            LeftHand = true;
            if (useGraphics == true)
            {
                g.DrawLine(pen, 50, 120, 0, 150);
            }
            else
            {
                var bmp = new Bitmap(Properties.Resources.left_hand);
                g.DrawImage(bmp, 50, 120, 0, 150);

            }
        }

        private void addRightHand()
        {
            RightHand = true;
            if (useGraphics == true)
            {
                g.DrawLine(pen, 50, 120, 100, 150);
            }
            else
            {
                var bmp = new Bitmap(Properties.Resources.right_hand);
                g.DrawImage(bmp, 50, 120, 100, 150);

            }
        }

        private void addLeftLeg()
        {
            LeftLeg = true;
            if (useGraphics == true)
            {
                g.DrawLine(pen, 50, 190, 0, 250);
            }
            else
            {
                var bmp = new Bitmap(Properties.Resources.left_leg);
                g.DrawImage(bmp, 50, 190, 0, 250);

            }
        }

        private void addRightLeg()
        {
            RightLeg = true;
            if (useGraphics == true)
            {
                g.DrawLine(pen, 50, 190, 100, 250);
            }
            else
            {
                var bmp = new Bitmap(Properties.Resources.right_leg);
                g.DrawImage(bmp, 50, 190, 100, 250);

            }
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


    }

    
}
