using System;
using ZJModbus.App.Attributes;


namespace ZJModbus.App.Entities
{
    public class AOEntity
    {
        public static readonly byte[] DATA_CMD = new byte[] { 0x0, 0x3, 0x3, 0x0, 0x0, 0x6 };
        
        private int ranshaoshuchuliang;
        [Description(Name = "燃烧输出量", Unit = "%")]
        public int RanShaoShuChuLiang { get { return ranshaoshuchuliang; } }
        [Byte(ByteIndex = 0)]
        public void SetRanShaoShuChuLiang(int data)
        {
            ranshaoshuchuliang = data;
        }
        private int xunhuanshuchuliang;
        [Description(Name = "循环输出量", Unit = "%")]
        public int XunHuanShuChuLiang { get { return xunhuanshuchuliang; } }
        [Byte(ByteIndex = 1)]
        public void SetXunHuanShuChuLiang(int data)
        {
            xunhuanshuchuliang = data;
        }
        private int jishuishuchuliang;
        [Description(Name = "给水输出量", Unit = "%")]
        public int JiShuiShuChuLiang { get { return jishuishuchuliang; } }
        [Byte(ByteIndex = 2)]
        public void SetJiShuiShuChuLiang(int data)
        {
            jishuishuchuliang = data;
        }
        private int yinfengshuchuliang;
        [Description(Name = "引风输出量", Unit = "%")]
        public int YinFengShuChuLiang { get { return yinfengshuchuliang; } }
        [Byte(ByteIndex = 3)]
        public void SetYinFengShuChuLiang(int data)
        {
            yinfengshuchuliang = data;
        }
        private int gufengshuchuliang;
        [Description(Name = "鼓风输出量", Unit = "%")]
        public int GuFengShuChuLiang { get { return gufengshuchuliang; } }
        [Byte(ByteIndex = 4)]
        public void SetGuFengShuChuLiang(int data)
        {
            gufengshuchuliang = data;
        }
        private int ecigufengshuchuliang;
        [Description(Name = "二次鼓风输出量", Unit = "%")]
        public int ECiGuFengShuChuLiang { get { return ecigufengshuchuliang; } }
        [Byte(ByteIndex = 5)]
        public void SetECiGuFengShuChuLiang(int data)
        {
            ecigufengshuchuliang = data;
        }
        private int lupaihuojinliaoshuchuliang;
        [Description(Name = "炉排或进料输出量", Unit = "%")]
        public int LuPaiHuoJinLiaoShuChuLiang { get { return lupaihuojinliaoshuchuliang; } }
        [Byte(ByteIndex = 6)]
        public void SetLuPaiHuoJinLiaoShuChuLiang(int data)
        {
            lupaihuojinliaoshuchuliang = data;
        }
    }
}
