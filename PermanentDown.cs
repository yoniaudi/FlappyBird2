using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public class PermanentDown : Interactable
    {
        public PermanentDown(Game game) : base(new PictureBox(), new Timer(), game.PermanentSpeed, 50) { }

        ~PermanentDown() { }

        public override void creation(Form form)
        {
            interactableImage.BackColor = Color.Transparent;
            interactableImage.Tag = objType = "permDown";
            interactableImage.Image = Properties.Resources.pipe;
            interactableImage.SizeMode = PictureBoxSizeMode.StretchImage;
            interactableImage.Left = objLeft = rand.Next(1100, 1250);
            interactableImage.Top = objTop = rand.Next(250, 300);
            interactableImage.Height = objHeight = 200;
            interactableImage.Width = objWidth = 80;
            interactableImage.BringToFront();
            form.Controls.Add(interactableImage);
            time.Interval = timeSpeed;
            time.Tick += new EventHandler(objTimerEvent);
            time.Start();
        }
        public override void interact(Form1 form, Game game, bool forceDispose = false)
        {
            if (forceDispose || interactableImage.Left < -100) game.removeInteractable(this, form, forceDispose);
            else if (Game.checkBirdIntesection(form, InteractableImage.Bounds)) game.endGame(form);
            else Game.bulletsInteractions(this);
        }
        public override void objTimerEvent(object sender, EventArgs e)
        {
            interactableImage.Left -= picSpeed;
            objLeft = interactableImage.Left;
        }
    }
}
