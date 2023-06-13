using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public class Brick : Breakable
    {
        public Brick(Game game) : base(new PictureBox(), new Timer(), game.BrickSpeed, 50, Game.BrickHealth) { }

        ~Brick() { }

        public override void creation(Form form)
        {
            interactableImage.BackColor = Color.Transparent;
            interactableImage.Tag = objType = "brick";
            interactableImage.Image = Properties.Resources.brick;
            interactableImage.Left = objLeft = rand.Next(900, 1000);
            interactableImage.Top = objTop = rand.Next(170, 220);
            interactableImage.Height = objHeight = 30;
            interactableImage.Width = objWidth = 80;
            interactableImage.BringToFront();
            interactableImage.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(interactableImage);
            time.Interval = timeSpeed;
            time.Tick += new EventHandler(objTimerEvent);
            time.Start();
        }

        public override void objTimerEvent(object sender, EventArgs e)
        {
            interactableImage.Left -= picSpeed;
            objLeft = interactableImage.Left;
        }
    }
}
