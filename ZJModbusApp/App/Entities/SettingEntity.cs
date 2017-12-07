using System;
using ZJModbus.App.Attributes;

namespace ZJModbus.App.Entities
{
    public class SettingEntity
    {
        public static readonly byte[] DATA_CMD = new byte[] { 0x0, 0x3, 0x5, 0x0, 0x0, 0x16 };
        private int paiyanwendu;
        [Description(Name = "排烟温度", Unit = "℃")]
        public int PaiYanWenDu { get { return paiyanwendu; } }
        [Byte(ByteIndex = 0)]
        public void SetPaiYanWenDu(int data)
        {
            paiyanwendu = data;
        }
        private int baojingwendu;
        [Description(Name = "报警温度", Unit = "℃")]
        public int BaoJingWenDu { get { return baojingwendu; } }
        [Byte(ByteIndex = 1)]
        public void SetBaoJingWenDu(int data)
        {
            baojingwendu = data;
        }
        private int tingluwendu;
        [Description(Name = "停炉温度", Unit = "℃")]
        public int TingLuWenDu { get { return tingluwendu; } }
        [Byte(ByteIndex = 2)]
        public void SetTingLuWenDu(int data)
        {
            tingluwendu = data;
        }
        private int mubiaowendu;
        [Description(Name = "目标温度", Unit = "℃")]
        public int MuBiaoWenDu { get { return mubiaowendu; } }
        [Byte(ByteIndex = 3)]
        public void SetMuBiaoWenDu(int data)
        {
            mubiaowendu = data;
        }
        private int qiluwendu;
        [Description(Name = "启炉温度", Unit = "℃")]
        public int QiLuWenDu { get { return qiluwendu; } }
        [Byte(ByteIndex = 4)]
        public void SetQiLuWenDu(int data)
        {
            qiluwendu = data;
        }
        private int zhuanhuohuicha;
        [Description(Name = "转火回差", Unit = "℃")]
        public int ZhuanHuoHuiCha { get { return zhuanhuohuicha; } }
        [Byte(ByteIndex = 5)]
        public void SetZhuanHuoHuiCha(int data)
        {
            zhuanhuohuicha = data;
        }
        private int qiluhuicha;
        [Description(Name = "启炉回差", Unit = "℃")]
        public int QiLuHuiCha { get { return qiluhuicha; } }
        [Byte(ByteIndex = 6)]
        public void SetQiLuHuiCha(int data)
        {
            qiluhuicha = data;
        }
        private int kaibengwendu;
        [Description(Name = "开泵温度", Unit = "℃")]
        public int KaiBengWenDu { get { return kaibengwendu; } }
        [Byte(ByteIndex = 7)]
        public void SetKaiBengWenDu(int data)
        {
            kaibengwendu = data;
        }
        private int guanbengwendu;
        [Description(Name = "关泵温度", Unit = "℃")]
        public int GuanBengWenDu { get { return guanbengwendu; } }
        [Byte(ByteIndex = 8)]
        public void SetGuanBengWenDu(int data)
        {
            guanbengwendu = data;
        }
        private int baojingyali;
        [Description(Name = "报警压力", Unit = "MPa")]
        public int BaoJingYaLi { get { return baojingyali; } }
        [Byte(ByteIndex = 9)]
        public void SetBaoJingYaLi(int data)
        {
            baojingyali = data / 100;
        }
        private int tingluyali;
        [Description(Name = "停炉压力", Unit = "MPa")]
        public int TingLuYaLi { get { return tingluyali; } }
        [Byte(ByteIndex = 10)]
        public void SetTingLuYaLi(int data)
        {
            tingluyali = data / 100;
        }
        private int mubiaoyali;
        [Description(Name = "目标压力", Unit = "MPa")]
        public int MuBiaoYaLi { get { return mubiaoyali; } }
        [Byte(ByteIndex = 11)]
        public void SetMuBiaoYaLi(int data)
        {
            mubiaoyali = data / 100;
        }
        private int qiluyali;
        [Description(Name = "启炉压力", Unit = "MPa")]
        public int QiLuYaLi { get { return qiluyali; } }
        [Byte(ByteIndex = 12)]
        public void SetQiLuYaLi(int data)
        {
            qiluyali = data / 100;
        }
        private int zhuanhuohuichayali;
        [Description(Name = "转火回差压力", Unit = "MPa")]
        public int ZhuanHuoHuiChaYaLi { get { return zhuanhuohuichayali; } }
        [Byte(ByteIndex = 13)]
        public void SetZhuanHuoHuiChaYaLi(int data)
        {
            zhuanhuohuichayali = data / 100;
        }
        private int qiluhuichayali;
        [Description(Name = "启炉回差压力", Unit = "MPa")]
        public int QiLuHuiChaYaLi { get { return qiluhuichayali; } }
        [Byte(ByteIndex = 14)]
        public void SetQiLuHuiChaYaLi(int data)
        {
            qiluhuichayali = data / 100;
        }
        private int qianyanshi;
        [Description(Name = "前延时", Unit = "秒")]
        public int QianYanShi { get { return qianyanshi; } }
        [Byte(ByteIndex = 15)]
        public void SetQianYanShi(int data)
        {
            qianyanshi = data;
        }
        private int houyanshi;
        [Description(Name = "后延时", Unit = "秒")]
        public int HouYanShi { get { return houyanshi; } }
        [Byte(ByteIndex = 16)]
        public void SetHouYanShi(int data)
        {
            houyanshi = data;
        }
        private int qianchuisao;
        [Description(Name = "前吹扫", Unit = "秒")]
        public int QianChuiSao { get { return qianchuisao; } }
        [Byte(ByteIndex = 17)]
        public void SetQianChuiSao(int data)
        {
            qianchuisao = data;
        }
        private int houchuisao;
        [Description(Name = "后吹扫", Unit = "秒")]
        public int HouChuiSao { get { return houchuisao; } }
        [Byte(ByteIndex = 18)]
        public void SetHouChuiSao(int data)
        {
            houchuisao = data;
        }
        private int lubibaojingwendu;
        [Description(Name = "炉壁报警温度", Unit = "℃")]
        public int LuBiBaoJingWenDu { get { return lubibaojingwendu; } }
        [Byte(ByteIndex = 19)]
        public void SetLuBiBaoJingWenDu(int data)
        {
            lubibaojingwendu = data;
        }
        private int lutangchukoubaojingwendu;
        [Description(Name = "炉膛出口报警温度", Unit = "℃")]
        public int LuTangChuKouBaoJingWenDu { get { return lutangchukoubaojingwendu; } }
        [Byte(ByteIndex = 20)]
        public void SetLuTangChuKouBaoJingWenDu(int data)
        {
            lutangchukoubaojingwendu = data;
        }
        private int baohuwendu;
        [Description(Name = "保护温度", Unit = "℃")]
        public int BaoHuWenDu { get { return baohuwendu; } }
        [Byte(ByteIndex = 21)]
        public void SetBaoHuWenDu(int data)
        {
            baohuwendu = data;
        }
        private int bentipaiyanwendubaojingzhi;
        [Description(Name = "本体排烟温度报警值", Unit = "℃")]
        public int BenTiPaiYanWenDuBaoJingZhi { get { return bentipaiyanwendubaojingzhi; } }
        [Byte(ByteIndex = 22)]
        public void SetBenTiPaiYanWenDuBaoJingZhi(int data)
        {
            bentipaiyanwendubaojingzhi = data;
        }
    }
}
