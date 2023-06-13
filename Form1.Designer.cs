
namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //<summary>
        //Clean up any resources being used.
        //</summary>
        //<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBullet = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.Game_Timer = new System.Windows.Forms.Timer(this.components);
            this.lblHighScore = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.PictureBox();
            this.ScoreBox4 = new System.Windows.Forms.PictureBox();
            this.ScoreBox3 = new System.Windows.Forms.PictureBox();
            this.ScoreBox2 = new System.Windows.Forms.PictureBox();
            this.ground4 = new System.Windows.Forms.PictureBox();
            this.ground3 = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.ScoreBox1 = new System.Windows.Forms.PictureBox();
            this.HighScoreBox4 = new System.Windows.Forms.PictureBox();
            this.HighScoreBox3 = new System.Windows.Forms.PictureBox();
            this.HighScoreBox2 = new System.Windows.Forms.PictureBox();
            this.HighScoreBox1 = new System.Windows.Forms.PictureBox();
            this.StartGameImg = new System.Windows.Forms.PictureBox();
            this.ground7 = new System.Windows.Forms.PictureBox();
            this.ground6 = new System.Windows.Forms.PictureBox();
            this.ground5 = new System.Windows.Forms.PictureBox();
            this.lblOption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartGameImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBullet
            // 
            this.lblBullet.AutoSize = true;
            this.lblBullet.BackColor = System.Drawing.Color.Khaki;
            this.lblBullet.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Bold);
            this.lblBullet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBullet.Location = new System.Drawing.Point(3, 448);
            this.lblBullet.Margin = new System.Windows.Forms.Padding(0);
            this.lblBullet.Name = "lblBullet";
            this.lblBullet.Size = new System.Drawing.Size(164, 24);
            this.lblBullet.TabIndex = 4;
            this.lblBullet.Text = "Bullets: 10";
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.BackColor = System.Drawing.Color.Transparent;
            this.lblReset.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(231, 321);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(252, 25);
            this.lblReset.TabIndex = 6;
            this.lblReset.Text = "Reset High Score";
            this.lblReset.Click += new System.EventHandler(this.lblResetClick);
            // 
            // Game_Timer
            // 
            this.Game_Timer.Tick += new System.EventHandler(this.gameTimerTick);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(275, 66);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(162, 25);
            this.lblHighScore.TabIndex = 23;
            this.lblHighScore.Text = "High Score";
            // 
            // GameOver
            // 
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.Image = global::Final_Project.Properties.Resources.gameover;
            this.GameOver.Location = new System.Drawing.Point(168, 172);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(384, 84);
            this.GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameOver.TabIndex = 14;
            this.GameOver.TabStop = false;
            this.GameOver.Visible = false;
            // 
            // ScoreBox4
            // 
            this.ScoreBox4.BackColor = System.Drawing.Color.Transparent;
            this.ScoreBox4.Image = global::Final_Project.Properties.Resources._0;
            this.ScoreBox4.Location = new System.Drawing.Point(100, 10);
            this.ScoreBox4.Name = "ScoreBox4";
            this.ScoreBox4.Size = new System.Drawing.Size(24, 36);
            this.ScoreBox4.TabIndex = 17;
            this.ScoreBox4.TabStop = false;
            this.ScoreBox4.Visible = false;
            // 
            // ScoreBox3
            // 
            this.ScoreBox3.BackColor = System.Drawing.Color.Transparent;
            this.ScoreBox3.Image = global::Final_Project.Properties.Resources._0;
            this.ScoreBox3.Location = new System.Drawing.Point(70, 10);
            this.ScoreBox3.Name = "ScoreBox3";
            this.ScoreBox3.Size = new System.Drawing.Size(24, 36);
            this.ScoreBox3.TabIndex = 16;
            this.ScoreBox3.TabStop = false;
            this.ScoreBox3.Visible = false;
            // 
            // ScoreBox2
            // 
            this.ScoreBox2.BackColor = System.Drawing.Color.Transparent;
            this.ScoreBox2.Image = global::Final_Project.Properties.Resources._0;
            this.ScoreBox2.Location = new System.Drawing.Point(40, 10);
            this.ScoreBox2.Name = "ScoreBox2";
            this.ScoreBox2.Size = new System.Drawing.Size(24, 36);
            this.ScoreBox2.TabIndex = 15;
            this.ScoreBox2.TabStop = false;
            this.ScoreBox2.Visible = false;
            // 
            // ground4
            // 
            this.ground4.BackColor = System.Drawing.Color.Transparent;
            this.ground4.Image = global::Final_Project.Properties.Resources.ground;
            this.ground4.Location = new System.Drawing.Point(1008, 425);
            this.ground4.Name = "ground4";
            this.ground4.Size = new System.Drawing.Size(336, 112);
            this.ground4.TabIndex = 13;
            this.ground4.TabStop = false;
            // 
            // ground3
            // 
            this.ground3.BackColor = System.Drawing.Color.Transparent;
            this.ground3.Image = global::Final_Project.Properties.Resources.ground;
            this.ground3.Location = new System.Drawing.Point(672, 425);
            this.ground3.Name = "ground3";
            this.ground3.Size = new System.Drawing.Size(336, 112);
            this.ground3.TabIndex = 12;
            this.ground3.TabStop = false;
            // 
            // ground2
            // 
            this.ground2.BackColor = System.Drawing.Color.Transparent;
            this.ground2.Image = global::Final_Project.Properties.Resources.ground;
            this.ground2.Location = new System.Drawing.Point(336, 425);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(336, 112);
            this.ground2.TabIndex = 11;
            this.ground2.TabStop = false;
            // 
            // ground1
            // 
            this.ground1.BackColor = System.Drawing.Color.Transparent;
            this.ground1.Image = global::Final_Project.Properties.Resources.ground;
            this.ground1.Location = new System.Drawing.Point(0, 425);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(336, 112);
            this.ground1.TabIndex = 10;
            this.ground1.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.Image = global::Final_Project.Properties.Resources.yellowbirdMidflap;
            this.Bird.Location = new System.Drawing.Point(100, 200);
            this.Bird.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(40, 30);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            // 
            // ScoreBox1
            // 
            this.ScoreBox1.BackColor = System.Drawing.Color.Transparent;
            this.ScoreBox1.Image = global::Final_Project.Properties.Resources._0;
            this.ScoreBox1.Location = new System.Drawing.Point(10, 10);
            this.ScoreBox1.Name = "ScoreBox1";
            this.ScoreBox1.Size = new System.Drawing.Size(24, 36);
            this.ScoreBox1.TabIndex = 9;
            this.ScoreBox1.TabStop = false;
            // 
            // HighScoreBox4
            // 
            this.HighScoreBox4.BackColor = System.Drawing.Color.Transparent;
            this.HighScoreBox4.Image = global::Final_Project.Properties.Resources._0;
            this.HighScoreBox4.Location = new System.Drawing.Point(300, 120);
            this.HighScoreBox4.Name = "HighScoreBox4";
            this.HighScoreBox4.Size = new System.Drawing.Size(24, 36);
            this.HighScoreBox4.TabIndex = 18;
            this.HighScoreBox4.TabStop = false;
            // 
            // HighScoreBox3
            // 
            this.HighScoreBox3.BackColor = System.Drawing.Color.Transparent;
            this.HighScoreBox3.Image = global::Final_Project.Properties.Resources._0;
            this.HighScoreBox3.Location = new System.Drawing.Point(330, 120);
            this.HighScoreBox3.Name = "HighScoreBox3";
            this.HighScoreBox3.Size = new System.Drawing.Size(24, 36);
            this.HighScoreBox3.TabIndex = 19;
            this.HighScoreBox3.TabStop = false;
            // 
            // HighScoreBox2
            // 
            this.HighScoreBox2.BackColor = System.Drawing.Color.Transparent;
            this.HighScoreBox2.Image = global::Final_Project.Properties.Resources._0;
            this.HighScoreBox2.Location = new System.Drawing.Point(360, 120);
            this.HighScoreBox2.Name = "HighScoreBox2";
            this.HighScoreBox2.Size = new System.Drawing.Size(24, 36);
            this.HighScoreBox2.TabIndex = 20;
            this.HighScoreBox2.TabStop = false;
            // 
            // HighScoreBox1
            // 
            this.HighScoreBox1.BackColor = System.Drawing.Color.Transparent;
            this.HighScoreBox1.Image = global::Final_Project.Properties.Resources._0;
            this.HighScoreBox1.Location = new System.Drawing.Point(390, 120);
            this.HighScoreBox1.Name = "HighScoreBox1";
            this.HighScoreBox1.Size = new System.Drawing.Size(24, 36);
            this.HighScoreBox1.TabIndex = 21;
            this.HighScoreBox1.TabStop = false;
            // 
            // StartGameImg
            // 
            this.StartGameImg.BackColor = System.Drawing.Color.Transparent;
            this.StartGameImg.Image = global::Final_Project.Properties.Resources.startgame;
            this.StartGameImg.Location = new System.Drawing.Point(233, 32);
            this.StartGameImg.Name = "StartGameImg";
            this.StartGameImg.Size = new System.Drawing.Size(248, 375);
            this.StartGameImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartGameImg.TabIndex = 22;
            this.StartGameImg.TabStop = false;
            this.StartGameImg.Click += new System.EventHandler(this.StartGameImgClick);
            // 
            // ground7
            // 
            this.ground7.BackColor = System.Drawing.Color.Transparent;
            this.ground7.Image = global::Final_Project.Properties.Resources.ground;
            this.ground7.Location = new System.Drawing.Point(530, 425);
            this.ground7.Name = "ground7";
            this.ground7.Size = new System.Drawing.Size(336, 112);
            this.ground7.TabIndex = 26;
            this.ground7.TabStop = false;
            // 
            // ground6
            // 
            this.ground6.BackColor = System.Drawing.Color.Transparent;
            this.ground6.Image = global::Final_Project.Properties.Resources.ground;
            this.ground6.Location = new System.Drawing.Point(194, 425);
            this.ground6.Name = "ground6";
            this.ground6.Size = new System.Drawing.Size(336, 112);
            this.ground6.TabIndex = 25;
            this.ground6.TabStop = false;
            // 
            // ground5
            // 
            this.ground5.BackColor = System.Drawing.Color.Transparent;
            this.ground5.Image = global::Final_Project.Properties.Resources.ground;
            this.ground5.Location = new System.Drawing.Point(-142, 425);
            this.ground5.Name = "ground5";
            this.ground5.Size = new System.Drawing.Size(336, 112);
            this.ground5.TabIndex = 24;
            this.ground5.TabStop = false;
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.BackColor = System.Drawing.Color.Khaki;
            this.lblOption.Font = new System.Drawing.Font("OCR A Extended", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.Location = new System.Drawing.Point(625, 450);
            this.lblOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(93, 19);
            this.lblOption.TabIndex = 28;
            this.lblOption.Text = "Options";
            this.lblOption.Click += new System.EventHandler(this.lblOptionClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(724, 474);
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.lblBullet);
            this.Controls.Add(this.ScoreBox4);
            this.Controls.Add(this.ScoreBox3);
            this.Controls.Add(this.ScoreBox2);
            this.Controls.Add(this.ground4);
            this.Controls.Add(this.ground3);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.ScoreBox1);
            this.Controls.Add(this.HighScoreBox4);
            this.Controls.Add(this.HighScoreBox3);
            this.Controls.Add(this.HighScoreBox2);
            this.Controls.Add(this.HighScoreBox1);
            this.Controls.Add(this.StartGameImg);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.ground7);
            this.Controls.Add(this.ground6);
            this.Controls.Add(this.ground5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FlappyBird 2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighScoreBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartGameImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox Bird;
        public System.Windows.Forms.Label lblBullet;
        public System.Windows.Forms.Label lblReset;
        public System.Windows.Forms.PictureBox ground1;
        public System.Windows.Forms.PictureBox ground2;
        public System.Windows.Forms.PictureBox ground3;
        public System.Windows.Forms.PictureBox ground4;
        public System.Windows.Forms.PictureBox GameOver;
        public System.Windows.Forms.PictureBox ScoreBox1;
        public System.Windows.Forms.PictureBox ScoreBox2;
        public System.Windows.Forms.PictureBox ScoreBox3;
        public System.Windows.Forms.PictureBox ScoreBox4;
        public System.Windows.Forms.PictureBox HighScoreBox4;
        public System.Windows.Forms.PictureBox HighScoreBox3;
        public System.Windows.Forms.PictureBox HighScoreBox2;
        public System.Windows.Forms.PictureBox HighScoreBox1;
        public System.Windows.Forms.Timer Game_Timer;
        public System.Windows.Forms.PictureBox StartGameImg;
        public System.Windows.Forms.Label lblHighScore;
        public System.Windows.Forms.PictureBox ground7;
        public System.Windows.Forms.PictureBox ground6;
        public System.Windows.Forms.PictureBox ground5;
        private System.Windows.Forms.Label lblOption;
    }
}