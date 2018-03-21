using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DAQ
{   
    [Serializable]
    class MySetting
    {
        string _chtCom = "COM1";
        string baseDir = @"D:\TestData";
        double ohmupper = 30;
        double ohmlower = 20;
        double ohmupper1 = 30;
        double ohmlower1 = 20;
        string password = "12306";
        int modelIndex = 0;

        
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        List<OhmPara> ohmparas = new List<OhmPara>();
        public string ChtCom { get => _chtCom; set => _chtCom = value; }
        public Dictionary<string, string> Dictionary { get => dictionary; set => dictionary = value; }
        public string BaseDir { get => baseDir; set => baseDir = value; }
        public double Ohmupper { get => ohmupper; set => ohmupper = value; }
        public double Ohmlower { get => ohmlower; set => ohmlower = value; }
        public List<OhmPara> Ohmparas { get => ohmparas; set => ohmparas = value; }
        public string Password { get => password; set => password = value; }
        public int ModelIndex { get => modelIndex; set => modelIndex = value; }
        public double SecOhmupper { get => ohmupper1; set => ohmupper1 = value; }
        public double SecOhmlower { get => ohmlower1; set => ohmlower1 = value; }

        public static MySetting GetMySetting()
        {
            return DeSerialize();
        }

        public  MySetting()
        {
            for(int i=0;i<18;i++)
            {
                dictionary.Add(new string((char)('A' + i), 1), new string((char)('A' + i), 1));
            }
        }
        public static void Serialize(MySetting Setting)
        {
           string _fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.bin");
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Setting);
            stream.Close();
        }
        public static MySetting DeSerialize()
        {
            IFormatter formatter = new BinaryFormatter();
            string _fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Setting.bin");
            if (File.Exists(_fileName))
            {
                Stream stream = new FileStream(_fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                MySetting setting = null;
                try
                {
                    setting = (MySetting)formatter.Deserialize(stream);
                }
                finally
                {
                    stream.Close();
                }
                return setting;
            }
            else
            {
                Serialize(new MySetting());
                return new MySetting();
            }
        }
    }
    [Serializable]
    public class OhmPara
    {
        public string Name { get; set; }
        public double UpperValue { get; set; }
        public double LowerValue { get; set; }
        public double SecUpperValue { get; set; }
        public double SecLowerValue { get; set; }
    }

    public class COMMANDS
    {
        public static string[] CMD_AUTO_RANGE = { "FUNCTION:RANGE:AUTO ON", "FUNCTION:RANGE:AUTO OFF" };
        public static string[] CMD_RATE = { "FUNCTION:RATE FAST", "FUNCTION:RATE MED" , "FUNCTION:RATE SLOW" };
        public static string[] CMD_Source = { "TRIGger:SOURce INT", "TRIGger:SOURce EXT", "TRIGger:SOURce MAN", "TRIGger:SOURce A.HOLD" };
        public static string[] CMD_Range = { "FUNCtion:RANGe 0", "FUNCtion:RANGe 1", "FUNCtion:RANGe 2", "FUNCtion:RANGe 3", "FUNCtion:RANGe 4", "FUNCtion:RANGe 5", "FUNCtion:RANGe 6", "FUNCtion:RANGe 7", "FUNCtion:RANGe 8", "FUNCtion:RANGe 9" };
        public static string GetCMD_HIGH(double upper)
        {
            return string.Format("COMParator:HIGH {0}", upper);
        }
        public static string GetCMD_LOW(double low)
        {
            return string.Format("COMParator:LOW {0}", low);
        }
    }
}
