using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Options : Form
    {
        Game game;
        Form1 form1;
        public bool Saved { get; set; } = false;
        public bool Loaded { get; set; } = false;
        public Options(Game game, Form1 form1)
        {
            InitializeComponent();
            this.game = game;
            this.form1 = form1;
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            if (game.GameStarted)
            {
                form1.saveGame(this);
                FileNameTextBox.Text = form1.fileName;
            }
        }

        private void btnLoadClick(object sender, EventArgs e)
        {
            form1.loadGame(this);
            FileLocationTextBox.Text = form1.fileLocation;
        }

        private void btnCloseClick(object sender, EventArgs e)
        {
            if (Saved)
            {
                Saved = false;
                game.continueGameAfterSaving(form1);
            }
            else if (Loaded)
                Loaded = false;
            else
            {
                if (game.GameStarted)
                {
                    form1.Game_Timer.Start();
                    form1.playerTime.Start();
                    for (int i = game.interactables.Count - 1; i >= 0; i--)
                        game.interactables[i].Time.Start();
                    form1.music.PlayLooping();
                }
            }
            form1.OptionIsClosed = true;
            this.Dispose();
        }
    }
}