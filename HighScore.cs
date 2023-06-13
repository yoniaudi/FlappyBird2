using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Final_Project
{
    [Serializable]
    public class HighScore
    {
        private int score;

        [XmlAttribute]
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public HighScore() { score = 0; }

        ~HighScore() { }

        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(HighScore));
                XML.Serialize(stream, this);
            }
        }

        public static HighScore Load(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(HighScore));
                return (HighScore)XML.Deserialize(stream);
            }
        }
    }
}
