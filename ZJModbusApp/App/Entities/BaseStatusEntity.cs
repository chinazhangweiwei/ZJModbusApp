using System;
using ZJModbus.App.Attributes;

namespace ZJModbus.App.Entities
{
    
    public class BaseStatusEntity
    {
        public static readonly byte[] DATA_CMD = new byte[] { 0x0, 0x3, 0x6, 0x0, 0x0, 0xB };
        public enum FuelType
        {
            油气 = 0,
            电 = 1,
            煤 = 2,
            生物质 = 3
        }
        public enum MediumType
        {
            热水 = 0,
            蒸汽 = 1,
            导热油 = 2
        }
        public enum RunStatus
        {
            关机 = 0,
            待机 = 1,
            运行 = 2,
            报警 = 3
        }
        private int theFuelType, theMediumType, theRunStatus, theSettingStutus;
        public enum SettingStutus
        {
            非设定状态 = 0,
            设定状态 = 1
        }

        [Byte(ByteIndex = 0)]
        public void SetFuelType(int data)
        {
            theFuelType = data;
        }
        [Description(Name = "燃料类型")]
        public FuelType TheFuelType { get { return (FuelType)theFuelType; } }

        [Byte(ByteIndex = 1)]
        public void SetMediumType(int data)
        {
            theMediumType = data;
        }
        [Description(Name = "介质类型")]
        public MediumType TheMediumType { get { return (MediumType)theMediumType; } }

        [Byte(ByteIndex = 2)]
        public void SetRunStatus(int data)
        {
            theRunStatus = data;
        }
        [Description(Name = "运行状态")]
        public RunStatus TheRunStatus { get { return (RunStatus)theRunStatus; } }
        [Byte(ByteIndex = 3)]
        public void SetSettingStutus(int data)
        {
            theSettingStutus = data;
        }
        [Description(Name = "设定状态")]
        public SettingStutus TheSettingStutus { get { return (SettingStutus)theSettingStutus; } }


        private int year, month, day, hour, minute, second;
        [Byte(ByteIndex = 4)]
        public void SetYear(int data)
        {
            year = 2000+data;
        }
        [Byte(ByteIndex = 5)]
        public void SetMonth(int data)
        {
            month = data;
        }
        [Byte(ByteIndex = 6)]
        public void SetDay(int data)
        {
            day = data;
        }
        [Byte(ByteIndex = 8)]
        public void SetHour(int data)
        {
            hour = data;
        }
        [Byte(ByteIndex = 9)]
        public void SetMinute(int data)
        {
            minute = data;
        }
        [Byte(ByteIndex = 10)]
        public void SetSecond(int data)
        {
            second = data;
        }
        public DateTime Now { get { return new DateTime(year, month, day, hour, minute, second); } }

        [Description(Name = "设备时间")]
        public string DeviceDatetime { get { return Now.ToString("yy-MM-dd HH:mm:ss"); } }

    }
}
