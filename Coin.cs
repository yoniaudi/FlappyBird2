using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public class Coin : Interactable
    {
        public Coin(Game game) : base(new PictureBox(), new Timer(), game.CoinSpeed, 50)
        {

        }

        ~Coin() { }

        public override void creation(Form form)
        {
            interactableImage.BackColor = Color.Transparent;
            interactableImage.Tag = objType = "coin";
            interactableImage.Image = Properties.Resources.coin;
            interactableImage.Left = objLeft = rand.Next(800, 900);
            interactableImage.Top = objTop = rand.Next(170, 220);
            interactableImage.Height = objHeight = 25;
            interactableImage.Width = objWidth = 25;
            interactableImage.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(interactableImage);
            time.Interval = timeSpeed;
            time.Tick += new EventHandler(objTimerEvent);
            time.Start();
        }
        public override void interact(Form1 form, Game game, bool forceDispose = false)
        {
            if (forceDispose || interactableImage.Left < -100) game.removeInteractable(this, form, forceDispose);
            else if (Game.checkBirdIntesection(form, interactableImage.Bounds))
            {
                game.Score++;
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
