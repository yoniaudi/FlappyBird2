using System;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public abstract class Breakable : Interactable
    {
        protected int health;

        public Breakable(PictureBox p, Timer t, int pictureSpeed, int timeSpeed, int health) : base(p, t, pictureSpeed, timeSpeed)
        {
            Health = health;
        }

        ~Breakable() { }
        public override void interact(Form1 form, Game game, bool forceDispose = false)
        {
            if (forceDispose || interactableImage.Left < -100) game.removeInteractable(this, form, forceDispose);
            else if (Game.checkBirdIntesection(form, InteractableImage.Bounds)) game.endGame(form);
            else
            {
                health = Math.Max(0, health - Game.bulletsInteractions(this));
                if (health == 0)
                {
                    game.Score++;
                    game.removeInteractable(this, form);
                }
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
    }
}
