using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        public Timer playerTime = new Timer();
        public SoundPlayer music = new SoundPlayer(Properties.Resources.Music);
        public string fileName;
        public string fileLocation;
        public bool OptionIsClosed { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
            game.initializeAnimations();
            game.highScoreInitialize(this);
            playerTime.Interval = 80;
            playerTime.Tick += movementController;
        }
        private void Form1KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space) && !game.GameStarted && !game.GameAfterLoad) game.startGame(this);
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space) && game.GameAfterLoad) game.continueGameAfterLoading(this);
            if (e.KeyCode == Keys.Up) game.MoveUp = true;
            if (e.KeyCode == Keys.Down) game.MoveDown = true;
            if (e.KeyCode == Keys.Left) game.MoveLeft = true;
            if (e.KeyCode == Keys.Right) game.MoveRight = true;
            if (e.KeyCode == Keys.Space && game.GameStarted) game.IsShooting = true;
            if (e.KeyCode == Keys.R && !game.GameStarted) game.resetHighScore(this);
        }
        private void Form1KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) game.MoveUp = false;
            if (e.KeyCode == Keys.Down) game.MoveDown = false;
            if (e.KeyCode == Keys.Left) game.MoveLeft = false;
            if (e.KeyCode == Keys.Right) game.MoveRight = false;
            if (e.KeyCode == Keys.Space && game.GameStarted) game.IsShooting = false;
        }
        private void gameTimerTick(object sender, EventArgs e)
        {
            game.shootingAction(this);
            game.animations(this);
            game.scoreUpdate(this);
            game.objectSpeedUpdate();
            game.gameLogic(this);
            if (game.GameEnded)
            {
                Game_Timer.Stop();
                game.clearAllInteractables(this);
            }
            else if (game.InteractableCreationCounter++ % 20 == 0) game.interactableGenerator(this);
        }
        private void movementController(object sender, EventArgs e)
        {
            if (game.MoveUp && Bird.Top > 0) Bird.Top -= Game.PlayerSpeed;
            if (game.MoveDown) Bird.Top += Game.PlayerSpeed;
            if (game.MoveLeft && Bird.Left > 0) Bird.Left -= Game.PlayerSpeed;
            if (game.MoveRight && Bird.Right < 740) Bird.Left += Game.PlayerSpeed;
        }
        private void StartGameImgClick(object sender, EventArgs e)
        {
            if (!game.GameStarted) game.startGame(this);
        }
        private void lblResetClick(object sender, EventArgs e)
        {
            if (!game.GameStarted) game.resetHighScore(this);
        }

        private void lblOptionClick(object sender, EventArgs e)
        {
            if (OptionIsClosed)
            {
                OptionIsClosed = false;
                Options options = new Options(game, this);
                try
                {
                    Game_Timer.Stop();
                    playerTime.Stop();
                    music.Stop();
                    for (int i = game.interactables.Count - 1; i >= 0; i--)
                        game.interactables[i].Time.Stop();
                    options.StartPosition = FormStartPosition.Manual;
                    options.TopMost = true;
                    options.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void saveGame(Options form2)
        {
            game.stopGameForSaving(this);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, game);
                }
            }
            fileName = saveFileDialog1.FileName;
            form2.Saved = true;
        }

        public void loadGame(Options form2)
        {
            game.clearAllInteractables(this);
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                game = (Game)binaryFormatter.Deserialize(stream);
            }
            fileLocation = openFileDialog1.FileName;
            form2.Loaded = true;
            game.stopGameAfterLoad(this);
            for (int i = game.interactables.Count - 1; i >= 0; i--)
            {
                switch (game.interactables[i].ObjType)
                {
                    case "coin":
                        loadInteractables(game.interactables[i]);
                        game.interactables[i].InteractableImage.Image = Properties.Resources.coin;
                        break;
                    case "gun":
                        loadInteractables(game.interactables[i]);
                        game.interactables[i].InteractableImage.Image = Properties.Resources.powerup;
                        break;
                    case "permDown":
                        loadInteractables(game.interactables[i]);
                        game.interactables[i].InteractableImage.Image = Properties.Resources.pipe;
                        break;
                    case "permUp":
                        loadInteractables(game.interactables[i]);
                        game.interactables[i].InteractableImage.Image = Properties.Resources.pipedown;
                        break;
                    case "brick":
                        loadInteractables(game.interactables[i]);
                        game.interactables[i].InteractableImage.Image = Properties.Resources.brick;
                        break;
                    case "monster":
                        loadInteractables(game.interactables[i]);
                        Monster temp = (Monster)game.interactables[i];
                        if (temp.IsRed) game.interactables[i].InteractableImage.Image = Properties.Resources.redbirdMidflap;
                        else game.interactables[i].InteractableImage.Image = Properties.Resources.bluebirdMidflap;
                        break;
                    default: break;
                }
            }
        }

        public void loadInteractables(Interactable obj)
        {
            obj.InteractableImage = new PictureBox();
            obj.Time = new Timer();
            obj.InteractableImage.BackColor = Color.Transparent;
            obj.InteractableImage.Left = obj.ObjLeft;
            obj.InteractableImage.Top = obj.ObjTop;
            obj.InteractableImage.Height = obj.ObjHeight;
            obj.InteractableImage.Width = obj.ObjWidth;
            obj.InteractableImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(obj.InteractableImage);
            obj.Time.Interval = obj.TimeSpeed;
            obj.Time.Tick += new EventHandler(obj.objTimerEvent);
        }
    }
}