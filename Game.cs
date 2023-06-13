using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public class Game
    {
        Random rand = new Random();

        // Data Lists Structures :
        public static HighScore highScore = new HighScore();
        public static List<Bullet> bullets = new List<Bullet>();
        public static List<Bitmap> numbers;
        public static List<Bitmap> birdAnimation;
        public List<Interactable> interactables;
        public int Score { get; set; } = 0;
        public int CoinSpeed { get; set; } = 10;
        public int BrickSpeed { get; set; } = 10;
        public int MonsterSpeed { get; set; } = 20;
        public int GunPowerupSpeed { get; set; } = 10;
        public int PermanentSpeed { get; set; } = 10;
        public int BulletSpeed { get; set; } = 10;
        public int InteractableCreationCounter { get; set; } = 0;
        public static int BrickHealth { get; set; } = 4;
        public static int MonsterHealth { get; set; } = 1;
        public static int GameSpeed { get; set; } = 20;
        public int NumberOfBullets { get; set; } = 10;
        public static int PlayerSpeed { get; set; } = 20;
        public bool MoveUp { get; set; } = false;
        public bool MoveDown { get; set; } = false;
        public bool MoveLeft { get; set; } = false;
        public bool MoveRight { get; set; } = false;
        public bool GameStarted { get; set; } = false;
        public bool GameEnded { get; set; } = false;
        public bool IsShooting { get; set; } = false;
        public bool GameAfterLoad { get; set; } = false;
        public bool IsObjectSpeedUpdated { get; set; } = false;
        private int AnimationCounter1 { get; set; } = 0;
        private int AnimationCounter2 { get; set; } = 0;


        public Game()
        {
            interactables = new List<Interactable>();
            if (File.Exists("highscore.txt")) Game.highScore = HighScore.Load("highscore.txt");
        }

        ~Game() { }

        #region Game Logic

        public void gameLogic(Form1 form)
        {
            checkGroundCollision(form);
            for (int i = this.interactables.Count - 1; i >= 0; i--)
                interactables[i].interact(form, this, GameEnded);
            removeOffScreenBullets(form, GameEnded);
        }
        public void startGame(Form1 form)
        {
            showHighScore(form, false);
            resetGame(form);
            form.Game_Timer.Start();
            form.playerTime.Start();
            form.lblReset.Visible = false;
            GameStarted = true;
            GameEnded = false;
            form.music.PlayLooping();
            form.Bird.Show();
            form.GameOver.Hide();
        }
        private void resetGame(Form1 form)
        {
            Score = 0;
            PlayerSpeed = 20;
            NumberOfBullets = 10;
            BrickSpeed = 10;
            BulletSpeed = 10;
            CoinSpeed = 10;
            GunPowerupSpeed = 10;
            MonsterSpeed = 20;
            PermanentSpeed = 10;
            form.Bird.Top = 200;
            form.Bird.Left = 100;
            InteractableCreationCounter = 1;
            GameStarted = false;
            GameEnded = false;
            MoveUp = false;
            MoveDown = false;
            MoveLeft = false;
            MoveRight = false;
            IsShooting = false;
            IsObjectSpeedUpdated = false;
            form.GameOver.Hide();
            scoreUpdate(form);
        }
        public void endGame(Form1 form)
        {
            if (Score > highScore.Score)
            {
                highScore.Score = Score;
                highScore.Save("highscore.txt");
            }
            showHighScore(form, true);
            resetGame(form);
            form.playerTime.Stop();
            GameEnded = true;
            form.lblReset.Visible = true;
            form.music.Stop();
            form.Bird.Hide();
            form.GameOver.Show();
        }

        public void stopGameForSaving(Form1 form)
        {
            for (int i = interactables.Count - 1; i >= 0; i--)
                interactables[i].Time.Stop();
            form.Game_Timer.Stop();
        }

        public void continueGameAfterSaving(Form1 form)
        {
            for (int i = interactables.Count - 1; i >= 0; i--)
                interactables[i].Time.Start();
            form.Game_Timer.Start();
            form.playerTime.Start();
        }

        public void stopGameAfterLoad(Form1 form)
        {
            showHighScore(form, false);
            form.Bird.Top = 200;
            form.Bird.Left = 100;
            InteractableCreationCounter = 1;
            GameStarted = true;
            GameEnded = false;
            GameAfterLoad = true;
            MoveUp = false;
            MoveDown = false;
            MoveLeft = false;
            MoveRight = false;
            IsShooting = false;
            IsObjectSpeedUpdated = false;
            form.GameOver.Hide();
            scoreUpdate(form);
            form.lblReset.Visible = false;
            form.Bird.Show();
        }

        public void continueGameAfterLoading(Form1 form)
        {
            for (int i = interactables.Count - 1; i >= 0; i--)
                interactables[i].Time.Start();
            form.Game_Timer.Start();
            form.playerTime.Start();
            GameAfterLoad = false;
            GameStarted = true;
            form.music.PlayLooping();
        }

        public void insertInteractable(Interactable interactableObj, Form f)
        {
            this.interactables.Add(interactableObj);
            interactableObj.creation(f);
        }
        public void removeInteractable(Interactable interactableObj, Form form, bool forceDispose = false)
        {
            if (forceDispose || !interactableObj.isBeingDestroyed)
            {
                interactableObj.isBeingDestroyed = true;
                interactableObj.Time.Stop();
                interactableObj.Time.Dispose();
                interactableObj.InteractableImage.Dispose();
                interactableObj.Time = null;
                interactableObj.InteractableImage = null;
                this.interactables.Remove(interactableObj);
                form.Controls.Remove(interactableObj.InteractableImage);
            }
        }
        public void clearAllInteractables(Form1 form)
        {
            for (int i = interactables.Count - 1; i >= 0; i--)
                removeInteractable(interactables[i], form);
            removeOffScreenBullets(form, true);
        }
        public static bool checkBirdIntesection(Form1 form, Rectangle bounds)
        {
            return form.Bird.Bounds.IntersectsWith(bounds);
        }
        private void checkGroundCollision(Form1 form)
        {
            if (checkBirdIntesection(form, form.ground1.Bounds) ||
                checkBirdIntesection(form, form.ground2.Bounds) ||
                checkBirdIntesection(form, form.ground3.Bounds) ||
                checkBirdIntesection(form, form.ground4.Bounds))
                endGame(form);
        }
        public void shootingAction(Form1 form)
        {
            if (IsShooting && NumberOfBullets > 0)
            {
                Bullet bullet = new Bullet(this);
                bullet.FireDirection(form.Bird.Left + (form.Bird.Width / 2), form.Bird.Top + (form.Bird.Height / 2));
                form.Controls.Add(bullet.bulletPictureBox);
                bullets.Insert(0, bullet);
                form.lblBullet.Text = $"Bullets: {--NumberOfBullets}";
            }
        }
        public static int bulletsInteractions(Interactable obj)
        {
            int numberOfHits = 0;
            for (int i = Game.bullets.Count - 1; i >= 0; i--)
                if (obj.InteractableImage.Bounds.IntersectsWith(Game.bullets[i].bulletPictureBox.Bounds))
                {
                    Game.bullets[i].IsSetForDisposal = true;
                    numberOfHits++;
                }
            return numberOfHits;
        }
        private void removeOffScreenBullets(Form1 form, bool forceDispose = false)
        {
            for (int i = bullets.Count - 1; i >= 0; i--)
                if (forceDispose || bullets[i].IsSetForDisposal)
                {
                    form.Controls.Remove(bullets[i].bulletPictureBox);
                    bullets[i].Dispose();
                    bullets.RemoveAt(i);
                }
        }
        public void objectSpeedUpdate()
        {
            if (Score > 0 && Score % 10 == 0 && !IsObjectSpeedUpdated)
            {
                BrickSpeed += 2;
                BulletSpeed += 2;
                CoinSpeed += 2;
                GunPowerupSpeed += 2;
                MonsterSpeed += 2;
                PermanentSpeed += 2;
                IsObjectSpeedUpdated = true;
            }
            else if (Score % 10 != 0 && IsObjectSpeedUpdated)
                IsObjectSpeedUpdated = false;
        }
        public void interactableGenerator(Form1 form)
        {
            int random = rand.Next(0, 101);
            //evey 2 seconds have % chance to generate
            if (random % 3 == 0) // 33 %
            {
                insertInteractable(new Coin(this), form);
                insertInteractable(new Gun_Powerup(this), form);
            }
            if (random % 5 == 0) // 20%
            {
                insertInteractable(new Brick(this), form);
                insertInteractable(new Monster(this), form);
                insertInteractable(new Gun_Powerup(this), form);
            }
            if (random % 4 == 0) // 25% 
            {
                insertInteractable(new PermanentDown(this), form);
                insertInteractable(new PermanentUp(this), form);
            }
            else if (rand.Next(0, 2) == 1) insertInteractable(new PermanentUp(this), form);
            else insertInteractable(new PermanentDown(this), form);
            if (InteractableCreationCounter % 40 == 0) //evey 4 seconds have 50% chance to generate
            {
                if (rand.Next(0, 2) == 1) insertInteractable(new Monster(this), form); // 50%
                if (rand.Next(0, 2) == 1)
                {
                    insertInteractable(new PermanentDown(this), form); // 50%
                    insertInteractable(new PermanentUp(this), form);  // 50%
                }
                else insertInteractable(new PermanentUp(this), form);
            }
            if (InteractableCreationCounter % 60 == 0) //evey 6 seconds generate 3 enemies
            {
                insertInteractable(new Monster(this), form);
                insertInteractable(new Monster(this), form);
                insertInteractable(new Monster(this), form);
                insertInteractable(new Gun_Powerup(this), form);
            }
            if (InteractableCreationCounter >= 60) InteractableCreationCounter = 0;
        }
        #endregion

        #region Animations

        public void animations(Form1 form)
        {
            // Bird Fly Animation :
            AnimationCounter1 = (++AnimationCounter1) % (birdAnimation.Count);
            form.Bird.Image = birdAnimation[AnimationCounter1];

            // Bird Idle Animation :
            if (!MoveUp && !MoveDown && !MoveLeft && !MoveRight)
            {
                if (AnimationCounter2 >= 0 && AnimationCounter2 < 6)
                    form.Bird.Top -= PlayerSpeed / 10;
                else if (AnimationCounter2 >= 6 && AnimationCounter2 < 12)
                    form.Bird.Top += PlayerSpeed / 10;
                if (AnimationCounter2++ >= 12) AnimationCounter2 = 0;
            }

            // Ground Animation :
            form.ground4.Left -= 10;
            form.ground3.Left -= 10;
            form.ground2.Left -= 10;
            form.ground1.Left -= 10;
            if (form.ground1.Left < -336) form.ground1.Left = form.ground4.Right;
            else if (form.ground2.Left < -336) form.ground2.Left = form.ground1.Right;
            else if (form.ground3.Left < -336) form.ground3.Left = form.ground2.Right;
            else if (form.ground4.Left < -336) form.ground4.Left = form.ground3.Right;
        }
        public void initializeAnimations()
        {
            birdAnimation = new List<Bitmap>();
            birdAnimation.Add(Properties.Resources.yellowbirdMidflap);
            birdAnimation.Add(Properties.Resources.yellowbirdDownflap);
            birdAnimation.Add(Properties.Resources.yellowbirdUpflap);

            numbers = new List<Bitmap>();
            numbers.Add(Properties.Resources._0);
            numbers.Add(Properties.Resources._1);
            numbers.Add(Properties.Resources._2);
            numbers.Add(Properties.Resources._3);
            numbers.Add(Properties.Resources._4);
            numbers.Add(Properties.Resources._5);
            numbers.Add(Properties.Resources._6);
            numbers.Add(Properties.Resources._7);
            numbers.Add(Properties.Resources._8);
            numbers.Add(Properties.Resources._9);
        }
        #endregion

        #region Score

        public void scoreUpdate(Form1 form)
        {
            form.lblBullet.Text = $"Bullets: {NumberOfBullets}";

            // Score image update :
            if (Score == 0)
            {
                form.ScoreBox1.Image = numbers[0];
                form.ScoreBox2.Hide();
                form.ScoreBox3.Hide();
                form.ScoreBox4.Hide();
            }
            else if (Score < 10)
            {
                form.ScoreBox1.Image = numbers[Score];
            }
            else if (Score >= 10 && Score < 100)
            {
                form.ScoreBox2.Show();
                form.ScoreBox3.Hide();
                form.ScoreBox4.Hide();
                form.ScoreBox1.Image = numbers[Score / 10];
                form.ScoreBox2.Image = numbers[Score % 10];
            }
            else if (Score >= 100 && Score < 1000)
            {
                form.ScoreBox2.Show();
                form.ScoreBox3.Show();
                form.ScoreBox4.Hide();
                form.ScoreBox1.Image = numbers[Score / 100];
                form.ScoreBox2.Image = numbers[(Score / 10) % 10];
                form.ScoreBox3.Image = numbers[Score % 10];
            }
            else if (Score >= 1000 && Score < 10000)
            {
                form.ScoreBox2.Show();
                form.ScoreBox3.Show();
                form.ScoreBox4.Show();
                form.ScoreBox1.Image = numbers[Score / 1000];
                form.ScoreBox2.Image = numbers[(Score / 100) % 10];
                form.ScoreBox3.Image = numbers[(Score / 10) % 10];
                form.ScoreBox4.Image = numbers[Score % 10];
            }
            highScoreInitialize(form);
        }
        private void showHighScore(Form1 form, bool show)
        {
            if (show)
            {
                form.lblReset.Show();
                form.StartGameImg.Show();
                form.lblHighScore.Show();
                form.HighScoreBox1.Show();
                form.HighScoreBox2.Show();
                form.HighScoreBox3.Show();
                form.HighScoreBox4.Show();
            }
            else
            {
                form.lblReset.Hide();
                form.lblHighScore.Hide();
                form.StartGameImg.Hide();
                form.HighScoreBox1.Hide();
                form.HighScoreBox2.Hide();
                form.HighScoreBox3.Hide();
                form.HighScoreBox4.Hide();
            }
        }
        public void highScoreInitialize(Form1 form)
        {
            form.HighScoreBox1.Image = numbers[highScore.Score % 10];
            form.HighScoreBox2.Image = numbers[(highScore.Score / 10) % 10];
            form.HighScoreBox3.Image = numbers[(highScore.Score / 100) % 10];
            form.HighScoreBox4.Image = numbers[(highScore.Score / 1000) % 10];
        }
        public void resetHighScore(Form1 form)
        {
            highScore.Score = 0;
            highScore.Save("highscore.txt");

            form.HighScoreBox1.Image = form.HighScoreBox2.Image =
                form.HighScoreBox3.Image = form.HighScoreBox4.Image = numbers[0];
        }
        #endregion
    }
}
