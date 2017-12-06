using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Runtime.Serialization.Formatters.Binary;

namespace ZJModbus.App.Entities
{
    [Serializable]
    public class AppSetting
    {
        public string PortName { get; set; }
        public int Boude { get; set; }
        public int DataLength { get; set; }
        public int Interval { get; set; }
        public StopBits StopBit { get; set; }
        public Parity Parity { get; set; }

        private List<string> list = new List<string>();
        public string[] Devices { get { return list.ToArray(); } }
        public void AddDevice(string device)
        {
            list.Add(device);
        }
        public void DeleteDevice(string device)
        {
            list.Remove(device);
        }
        public void Save()
        {
            FileStream fs = new FileStream("setting.db", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }
        public static AppSetting Load()
        {
            if (!File.Exists("setting.db"))
                return null;

            FileStream fs = new FileStream("setting.db", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            var setting = (AppSetting)bf.Deserialize(fs);
            fs.Close();
            return setting;
        }
    }
}