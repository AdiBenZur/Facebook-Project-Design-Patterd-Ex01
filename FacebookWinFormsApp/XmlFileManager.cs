using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    class XmlFileManager
    {
        public bool RememberMe { get; set; }

        public string LastAccessToken { get; set; }

        private XmlFileManager() { }

        public void SaveToFile()
        {
            string fileName = "appSettings.xml";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

            using (Stream stream = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static XmlFileManager LoadFromFile()
        {
            XmlFileManager settings = null;
            string filePath = Path.Combine(Environment.CurrentDirectory, "appSettings.xml");

            try
            {
                using (Stream stream = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(XmlFileManager));
                    settings = serializer.Deserialize(stream) as XmlFileManager;
                }
            }
            catch
            {
                settings = new XmlFileManager();
            }

            return settings;
        }
    }
}
