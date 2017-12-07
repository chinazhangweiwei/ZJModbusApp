using System;
using ZJModbus.App.Attributes;

namespace ZJModbus.App.Entities
{
    public class StartStopEntity
    {
        public static readonly byte[] DATA_CMD = new byte[] { 0x0, 0x3, 0x5, 0x80, 0x0, 0xB };
        private int qidongshijian1;
        [Description(Name = "启动时间1")]
        public int QiDongShiJian1 { get { return qidongshijian1; } }
        [Byte(ByteIndex = 0)]
        public void SetQiDongShiJian1(int data)
        {
            qidongshijian1 = data;
        }
        private int tingzhishijian1;
        [Description(Name = "停止时间1")]
        public int TingZhiShiJian1 { get { return tingzhishijian1; } }
        [Byte(ByteIndex = 1)]
        public void SetTingZhiShiJian1(int data)
        {
            tingzhishijian1 = data;
        }
        private int qidongshijian2;
        [Description(Name = "启动时间2")]
        public int QiDongShiJian2 { get { return qidongshijian2; } }
        [Byte(ByteIndex = 2)]
        public void SetQiDongShiJian2(int data)
        {
            qidongshijian2 = data;
        }
        private int tingzhishijian2;
        [Description(Name = "停止时间2")]
        public int TingZhiShiJian2 { get { return tingzhishijian2; } }
        [Byte(ByteIndex = 3)]
        public void SetTingZhiShiJian2(int data)
        {
            tingzhishijian2 = data;
        }
        private int qidongshijian3;
        [Description(Name = "启动时间3")]
        public int QiDongShiJian3 { get { return qidongshijian3; } }
        [Byte(ByteIndex = 4)]
        public void SetQiDongShiJian3(int data)
        {
            qidongshijian3 = data;
        }
        private int tingzhishijian3;
        [Description(Name = "停止时间3")]
        public int TingZhiShiJian3 { get { return tingzhishijian3; } }
        [Byte(ByteIndex = 5)]
        public void SetTingZhiShiJian3(int data)
        {
            tingzhishijian3 = data;
        }
        private int qidongshijian4;
        [Description(Name = "启动时间4")]
        public int QiDongShiJian4 { get { return qidongshijian4; } }
        [Byte(ByteIndex = 6)]
        public void SetQiDongShiJian4(int data)
        {
            qidongshijian4 = data;
        }
        private int tingzhishijian4;
        [Description(Name = "停止时间4")]
        public int TingZhiShiJian4 { get { return tingzhishijian4; } }
        [Byte(ByteIndex = 7)]
        public void SetTingZhiShiJian4(int data)
        {
            tingzhishijian4 = data;
        }
        private int qidongshijian5;
        [Description(Name = "启动时间5")]
        public int QiDongShiJian5 { get { return qidongshijian5; } }
        [Byte(ByteIndex = 8)]
        public void SetQiDongShiJian5(int data)
        {
            qidongshijian5 = data;
        }
        private int tingzhishijian5;
        [Description(Name = "停止时间5")]
        public int TingZhiShiJian5 { get { return tingzhishijian5; } }
        [Byte(ByteIndex = 9)]
        public void SetTingZhiShiJian5(int data)
        {
            tingzhishijian5 = data;
        }
        private int qidongshijian6;
        [Description(Name = "启动时间6")]
        public int QiDongShiJian6 { get { return qidongshijian6; } }
        [Byte(ByteIndex = 10)]
        public void SetQiDongShiJian6(int data)
        {
            qidongshijian6 = data;
        }
        private int tingzhishijian6;
        [Description(Name = "停止时间6")]
        public int TingZhiShiJian6 { get { return tingzhishijian6; } }
        [Byte(ByteIndex = 11)]
        public void SetTingZhiShiJian6(int data)
        {
            tingzhishijian6 = data;
        }
    }
}
