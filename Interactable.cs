using System;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public abstract class Interactable
    {
        public bool isBeingDestroyed = false;
        [NonSerialized]
        protected PictureBox interactableImage;
        [NonSerialized]
        protected Timer time;
        protected int picSpeed;
        protected int timeSpeed;
        protected Random rand = new Random();
        protected string objType;
        protected int objLeft, objTop, objHeight, objWidth;

        public Interactable() { }

        public Interactable(PictureBox pic, Timer time, int picSpeed, int timeSpeed)
        {
            interactableImage = pic;
            this.time = time;
            this.picSpeed = picSpeed;
            this.timeSpeed = timeSpeed;
        }

        ~Interactable() { }

        public abstract void creation(Form form);
        public abstract void interact(Form1 form, Game game, bool forceDispose = false);
        public abstract void objTimerEvent(object sender, EventArgs e);

        public PictureBox InteractableImage
        {
            get
            {
                return interactableImage;
            }
            set
            {
                interactableImage = value;
            }
        }

        public Timer Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public int PicSpeed
        {
            get
            {
                return picSpeed;
            }
            set
            {
                picSpeed = value;
            }
        }

        public int TimeSpeed
        {
            get
            {
                return timeSpeed;
            }
            set
            {
                timeSpeed = value;
            }
        }

        public string ObjType
        {
            get
            {
                return objType;
            }
            set
            {
                objType = value;
            }
        }

        public int ObjLeft
        {
            get
            {
                return objLeft;
            }
            set
            {
                objLeft = value;
            }
        }

        public int ObjTop
        {
            get
            {
                return objTop;
            }
            set
            {
                objTop = value;
            }
        }

        public int ObjHeight
        {
            get
            {
                return objHeight;
            }
            set
            {
                objHeight = value;
            }
        }

        public int ObjWidth
        {
            get
            {
                return objWidth;
            }
            set
            {
                objWidth = value;
            }
        }
    }
}