using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public class Monster : Breakable
    {
        private Random rnd = new Random();
        private List<Bitmap> monsterAnimation;
        private int animationCounter1 = 0, animationCounter2 = 0;
        private bool isRed;

        public Monster(Game game) : base(new PictureBox(), new Timer(), game.MonsterSpeed, 50, Game.MonsterHealth)
        {
            InitializeAnimations(isRed = monsterColor());
        }

        ~Monster() { }

        public override void creation(Form form)
        {
            interactableImage.BackColor = Color.Transparent;
            interactableImage.Tag = objType = "monster";
            if (isRed) interactableImage.Image = Properties.Resources.redbirdMidflap;
            else interactableImage.Image = Properties.Resources.bluebirdMidflap;
            monsterSize();
            interactableImage.BringToFront();
            interactableImage.Top = objTop = rand.Next(170, 220);
            interactableImage.Left = objLeft = rand.Next(1050, 1200);
            interactableImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            interactableImage.SizeMode = PictureBoxSizeMode.StretchImage;
            objHeight = interactableImage.Height;
            objWidth = interactableImage.Width;
            form.Controls.Add(interactableImage);
            time.Interval = timeSpeed;
            time.Tick += new EventHandler(objTimerEvent);
            time.Start();
        }

        public override void objTimerEvent(object sender, EventArgs e)
        {
            interactableImage.Left -= picSpeed;
            objLeft = interactableImage.Left;
            animationCounter1 = (++animationCounter1) % (monsterAnimation.Count);
            interactableImage.Image = monsterAnimation[animationCounter1];

            if (animationCounter2 >= 0 && animationCounter2 < 6)
                interactableImage.Top -= picSpeed / 10;
            else if (animationCounter2 >= 6 && animationCounter2 < 12)
                interactableImage.Top += picSpeed / 10;
            if (animationCounter2++ >= 12) animationCounter2 = 0;
            objTop = interactableImage.Top;
        }

        private void InitializeAnimations(bool isRed)
        {
            monsterAnimation = new List<Bitmap>();
            if (isRed)
            {
                monsterAnimation.Add(Properties.Resources.redbirdMidflap);
                monsterAnimation.Add(Properties.Resources.redbirdDownflap);
                monsterAnimation.Add(Properties.Resources.redbirdUpflap);
            }
            else
            {
                monsterAnimation.Add(Properties.Resources.bluebirdMidflap);
                monsterAnimation.Add(Properties.Resources.bluebirdDownflap);
                monsterAnimation.Add(Properties.Resources.bluebirdUpflap);
            }
        }

        private void monsterSize()
        {
            int option = rand.Next(0, 3);
            switch (option)
            {
                case 0:
                    interactableImage.Size = new System.Drawing.Size(34, 24);
                    break;
                case 1:
                    interactableImage.Size = new System.Drawing.Size(44, 34);
                    break;
                default:
                    interactableImage.Size = new System.Drawing.Size(48, 38);
                    break;
            }
        }

        private bool monsterColor()
        {
            if (rand.Next(0, 2) == 1) return true;
            return false;
        }

        public bool IsRed
        {
            get
            {
                return isRed;
            }
            set
            {
                isRed = value;
            }
        }
    }
}
