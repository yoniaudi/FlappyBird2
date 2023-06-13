using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public class Gun_Powerup : Interactable
    {
        public Gun_Powerup(Game game) : base(new PictureBox(), new Timer(), game.GunPowerupSpeed, 50) { }

        ~Gun_Powerup() { }

        public override void creation(Form form)
        {
            interactableImage.BackColor = Color.Transparent;
            interactableImage.Tag = objType = "gun";
            interactableImage.Image = Properties.Resources.powerup;
            interactableImage.Left = objLeft = 800;
            interactableImage.Top = objTop = rand.Next(10, 390);
            interactableImage.Height = objHeight = 30;
            interactableImage.Width = objWidth = 30;
            interactableImage.SizeMode = PictureBoxSizeMode.StretchImage;
            interactableImage.BringToFront();
            form.Controls.Add(interactableImage);
            time.Interval = timeSpeed;
            time.Tick += new EventHandler(objTimerEvent);
            time.Start();
        }
        public override void interact(Form1 form, Game game, bool forceDispose = false)
        {
            if (forceDispose || interactableImage.Left < -100) game.removeInteractable(this, form, forceDispose);
            else if (Game.checkBirdIntesection(form, InteractableImage.Bounds))
            {
                game.NumberOfBullets += 5;
                game.removeInteractable(this, form);
            }
        }
        public override void objTimerEvent(object sender, EventArgs e)
        {
            interactableImage.Left -= picSpeed;
            objLeft = interactableImage.Left;
        }
    }
}
