using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SrvFolloweR
{
    static class DataHandler
    {
        internal static List<Reshuma> reshumas = new List<Reshuma>();
        internal static bool Benglish = false;
        internal static bool mainfullscreen = false;
        internal static bool isuser = false;
        internal static int selectedid = 0;
        internal static void Save()
        {
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
            //FileStream stream = new FileStream(@"Data/dat.xml", FileMode.OpenOrCreate);
            //if (reshumaBindingSource == null) { return; }
            try
            {
                XmlSerializer serializer = new XmlSerializer(reshumas.GetType());
                using (FileStream fs = new FileStream(@"Data/dat.xml", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    serializer.Serialize(fs, reshumas);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal static void Load()
        {
            if (!Directory.Exists("Data"))
                return;
            List<Reshuma> objectOut = default(List<Reshuma>);
            if (File.Exists(@"Data/dat.xml"))
            {
                try
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<Reshuma>));
                    using (FileStream fs = File.OpenRead(@"Data/dat.xml"))
                    {
                        objectOut = (List<Reshuma>)deserializer.Deserialize(fs);
                        fs.Close();
                        if (objectOut.Count>0)
                        {
                        reshumas = objectOut;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
