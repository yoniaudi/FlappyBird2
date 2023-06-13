using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    public class Bullet : IDisposable
    {
        public PictureBox bulletPictureBox;
        public Timer bulletTimer;
        private bool isSetForDisposal;
        private int bulletSpeed;

        public Bullet(Game game)
        {
            bulletPictureBox = new PictureBox();
            bulletTimer = new Timer();
            bulletSpeed = game.BulletSpeed;
        }

        ~Bullet() { }

        public void FireDirection(int bulletLeft, int bulletTop)
        {
            bulletPictureBox.BackColor = Color.White;
            bulletPictureBox.Size = new Size(10, 5);
            bulletPictureBox.Tag = "bullet";
            bulletPictureBox.Left = bulletLeft;
            bulletPictureBox.Top = bulletTop;
            bulletPictureBox.BringToFront();
            //form.Controls.Add(bullet);
            bulletTimer.Interval = bulletSpeed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        public void BulletTimerEvent(object sender, EventArgs e)
        {
            bulletPictureBox.Left += bulletSpeed;
            if (bulletPictureBox.Left > 900)
            {
                bulletTimer.Stop();
                IsSetForDisposal = true;
            }
        }

        public void Dispose()
        {
            bulletTimer.Stop();
            bulletTimer.Dispose();
            bulletPictureBox.Dispose();
            bulletPictureBox = null;
            bulletTimer = null;
        }

        public bool IsSetForDisposal { get => isSetForDisposal; set => isSetForDisposal = value; }
    }
}
