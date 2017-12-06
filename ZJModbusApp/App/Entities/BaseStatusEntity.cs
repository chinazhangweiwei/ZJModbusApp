using System;
using ZJModbus.App.Attributes;

namespace ZJModbus.App.Entities
{
    public class BaseStatusEntity
    {
        public enum FuelType
        {
            Gas = 0,
            Electric = 1,
            Coal = 2,
            Biomass = 3
        }
        public enum MediumType
        {
            Water = 0,
            Steam = 1,
            Oil = 2
        }
        public enum RunStatus
        {
            Closed = 0,
            Waiting = 1,
            Runing = 2,
            Alarming = 3
        }
        private int theFuelType, theMediumType, theRunStatus, theSettingStutus;
        public enum SettingStutus
        {
            NotSet = 0,
            Set = 1
        }

        [Byte(ByteIndex = 0)]
        public void SetFuelType(int data)
        {
            theFuelType = data;
        }
        public FuelType TheFuelType { get { return (FuelType)theFuelType; } }

        [Byte(ByteIndex = 1)]
        public void SetMediumType(int data)
        {
            theMediumType = data;
        }
        public MediumType TheMediumType { get { return (MediumType)theMediumType; } }

        [Byte(ByteIndex = 2)]
        public void SetRunStatus(int data)
        {
            theRunStatus = data;
        }
        public RunStatus TheRunStatus { get { return (RunStatus)theRunStatus; } }
        [Byte(ByteIndex = 3)]
        public void SetSettingStutus(int data)
        {
            theSettingStutus = data;
        }
        public SettingStutus TheSettingStutus { get { return (SettingStutus)theSettingStutus; } }


        private int year, month, day, hour, minute, second;
        [Byte(ByteIndex = 4)]
        public void SetYear(int data)
        {
            year = data;
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

    }
}
