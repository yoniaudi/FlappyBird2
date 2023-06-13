
namespace Final_Project
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileLocationTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.OptionTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblInstructionsText1 = new System.Windows.Forms.Label();
            this.lblInstructionsText2 = new System.Windows.Forms.Label();
            this.lblInstructionsText4 = new System.Windows.Forms.Label();
            this.lblInstructionsText3 = new System.Windows.Forms.Label();
            this.lblInstructionsText5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Coin = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Brick = new System.Windows.Forms.PictureBox();
            this.Ammunition = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ammunition)).BeginInit();
            this.SuspendLayout();
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Enabled = false;
            this.FileNameTextBox.Location = new System.Drawing.Point(112, 341);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(460, 19);
            this.FileNameTextBox.TabIndex = 0;
            // 
            // FileLocationTextBox
            // 
            this.FileLocationTextBox.Location = new System.Drawing.Point(112, 366);
            this.FileLocationTextBox.Name = "FileLocationTextBox";
            this.FileLocationTextBox.ReadOnly = true;
            this.FileLocationTextBox.Size = new System.Drawing.Size(460, 19);
            this.FileLocationTextBox.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 366);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoadClick);
            // 
            // OptionTitle
            // 
            this.OptionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OptionTitle.AutoSize = true;
            this.OptionTitle.Font = new System.Drawing.Font("OCR A Extended", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionTitle.Location = new System.Drawing.Point(118, 18);
            this.OptionTitle.Margin = new System.Windows.Forms.Padding(0);
            this.OptionTitle.Name = "OptionTitle";
            this.OptionTitle.Size = new System.Drawing.Size(327, 25);
            this.OptionTitle.TabIndex = 4;
            this.OptionTitle.Text = "Flappy Bird 2 Options";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("OCR A Extended", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(8, 81);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(166, 23);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Instructions";
            // 
            // lblInstructionsText1
            // 
            this.lblInstructionsText1.AutoSize = true;
            this.lblInstructionsText1.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInstructionsText1.Location = new System.Drawing.Point(8, 113);
            this.lblInstructionsText1.Name = "lblInstructionsText1";
            this.lblInstructionsText1.Size = new System.Drawing.Size(218, 22);
            this.lblInstructionsText1.TabIndex = 6;
            this.lblInstructionsText1.Text = "Press arrow key to move";
            // 
            // lblInstructionsText2
            // 
            this.lblInstructionsText2.AutoSize = true;
            this.lblInstructionsText2.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInstructionsText2.Location = new System.Drawing.Point(8, 143);
            this.lblInstructionsText2.Name = "lblInstructionsText2";
            this.lblInstructionsText2.Size = new System.Drawing.Size(224, 22);
            this.lblInstructionsText2.TabIndex = 7;
            this.lblInstructionsText2.Text = "Press space key to shoot";
            // 
            // lblInstructionsText4
            // 
            this.lblInstructionsText4.AutoSize = true;
            this.lblInstructionsText4.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInstructionsText4.Location = new System.Drawing.Point(8, 205);
            this.lblInstructionsText4.Name = "lblInstructionsText4";
            this.lblInstructionsText4.Size = new System.Drawing.Size(433, 22);
            this.lblInstructionsText4.TabIndex = 9;
            this.lblInstructionsText4.Text = "Collect ammunition to increase your bullet capacity";
            // 
            // lblInstructionsText3
            // 
            this.lblInstructionsText3.AutoSize = true;
            this.lblInstructionsText3.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInstructionsText3.Location = new System.Drawing.Point(8, 174);
            this.lblInstructionsText3.Name = "lblInstructionsText3";
            this.lblInstructionsText3.Size = new System.Drawing.Size(424, 22);
            this.lblInstructionsText3.TabIndex = 8;
            this.lblInstructionsText3.Text = "Collect coins and break breakables to earn points";
            // 
            // lblInstructionsText5
            // 
            this.lblInstructionsText5.AutoSize = true;
            this.lblInstructionsText5.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInstructionsText5.Location = new System.Drawing.Point(8, 235);
            this.lblInstructionsText5.Name = "lblInstructionsText5";
            this.lblInstructionsText5.Size = new System.Drawing.Size(253, 22);
            this.lblInstructionsText5.TabIndex = 10;
            this.lblInstructionsText5.Text = "Avoid unbreakable obstacles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(8, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Destroy enemies and breakables by shooting at them";
            // 
            // Coin
            // 
            this.Coin.BackColor = System.Drawing.Color.Transparent;
            this.Coin.BackgroundImage = global::Final_Project.Properties.Resources.coin;
            this.Coin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Coin.ErrorImage = null;
            this.Coin.Location = new System.Drawing.Point(499, 159);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(37, 37);
            this.Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin.TabIndex = 12;
            this.Coin.TabStop = false;
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1.BackgroundImage = global::Final_Project.Properties.Resources.redbirdUpflap;
            this.Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enemy1.ErrorImage = null;
            this.Enemy1.Location = new System.Drawing.Point(481, 251);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(37, 26);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1.TabIndex = 13;
            this.Enemy1.TabStop = false;
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2.BackgroundImage = global::Final_Project.Properties.Resources.bluebirdUpflap;
            this.Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enemy2.ErrorImage = null;
            this.Enemy2.Location = new System.Drawing.Point(524, 251);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(39, 26);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2.TabIndex = 14;
            this.Enemy2.TabStop = false;
            // 
            // Brick
            // 
            this.Brick.BackColor = System.Drawing.Color.Transparent;
            this.Brick.BackgroundImage = global::Final_Project.Properties.Resources.brick;
            this.Brick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Brick.ErrorImage = null;
            this.Brick.Location = new System.Drawing.Point(481, 285);
            this.Brick.Name = "Brick";
            this.Brick.Size = new System.Drawing.Size(82, 26);
            this.Brick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Brick.TabIndex = 15;
            this.Brick.TabStop = false;
            // 
            // Ammunition
            // 
            this.Ammunition.BackColor = System.Drawing.Color.Transparent;
            this.Ammunition.BackgroundImage = global::Final_Project.Properties.Resources.powerup;
            this.Ammunition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ammunition.ErrorImage = null;
            this.Ammunition.Location = new System.Drawing.Point(499, 204);
            this.Ammunition.Name = "Ammunition";
            this.Ammunition.Size = new System.Drawing.Size(37, 37);
            this.Ammunition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ammunition.TabIndex = 16;
            this.Ammunition.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(499, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCloseClick);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Ammunition);
            this.Controls.Add(this.Brick);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInstructionsText5);
            this.Controls.Add(this.lblInstructionsText4);
            this.Controls.Add(this.lblInstructionsText3);
            this.Controls.Add(this.lblInstructionsText2);
            this.Controls.Add(this.lblInstructionsText1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.OptionTitle);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.FileLocationTextBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ammunition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.TextBox FileLocationTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label OptionTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblInstructionsText1;
        private System.Windows.Forms.Label lblInstructionsText2;
        private System.Windows.Forms.Label lblInstructionsText4;
        private System.Windows.Forms.Label lblInstructionsText3;
        private System.Windows.Forms.Label lblInstructionsText5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Coin;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Brick;
        private System.Windows.Forms.PictureBox Ammunition;
        private System.Windows.Forms.Button btnClose;
    }
}