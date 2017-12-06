


using System;
using ZJModbus.App.Attributes;


namespace ZJModbus.App.Entities
{
    public class AlEmtity
    {
        private int bentipaiyanwendu;
        [Description(Name = "本体排烟温度", Unit = "℃")]
        public int BenTiPaiYanWenDu { get { return bentipaiyanwendu; } }
        [Byte(ByteIndex = 0)]
        public void SetBenTiPaiYanWenDu(int data)
        {
            bentipaiyanwendu = data;
        }
        private int paiyanwendu;
        [Description(Name = "排烟温度", Unit = "℃")]
        public int PaiYanWenDu { get { return paiyanwendu; } }
        [Byte(ByteIndex = 1)]
        public void SetPaiYanWenDu(int data)
        {
            paiyanwendu = data;
        }
        private int lushuiwendu;
        [Description(Name = "炉水温度", Unit = "℃")]
        public int LuShuiWenDu { get { return lushuiwendu; } }
        [Byte(ByteIndex = 2)]
        public void SetLuShuiWenDu(int data)
        {
            lushuiwendu = data;
        }
        private int chukouwendu;
        [Description(Name = "出口温度", Unit = "℃")]
        public int ChuKouWenDu { get { return chukouwendu; } }
        [Byte(ByteIndex = 3)]
        public void SetChuKouWenDu(int data)
        {
            chukouwendu = data;
        }
        private int rukouwendu;
        [Description(Name = "入口温度", Unit = "℃")]
        public int RuKouWenDu { get { return rukouwendu; } }
        [Byte(ByteIndex = 4)]
        public void SetRuKouWenDu(int data)
        {
            rukouwendu = data;
        }
        private int jienengqichukouwendu;
        [Description(Name = "节能器出口温度", Unit = "℃")]
        public int JieNengQiChuKouWenDu { get { return jienengqichukouwendu; } }
        [Byte(ByteIndex = 5)]
        public void SetJieNengQiChuKouWenDu(int data)
        {
            jienengqichukouwendu = data;
        }
        private int jienengqirukouwendu;
        [Description(Name = "节能器入口温度", Unit = "℃")]
        public int JieNengQiRuKouWenDu { get { return jienengqirukouwendu; } }
        [Byte(ByteIndex = 6)]
        public void SetJieNengQiRuKouWenDu(int data)
        {
            jienengqirukouwendu = data;
        }
        private int jishuiwendu;
        [Description(Name = "给水温度", Unit = "℃")]
        public int JiShuiWenDu { get { return jishuiwendu; } }
        [Byte(ByteIndex = 7)]
        public void SetJiShuiWenDu(int data)
        {
            jishuiwendu = data;
        }
        private int lutangwendu;
        [Description(Name = "炉膛温度", Unit = "℃")]
        public int LuTangWenDu { get { return lutangwendu; } }
        [Byte(ByteIndex = 8)]
        public void SetLuTangWenDu(int data)
        {
            lutangwendu = data;
        }
        private int lutangchukouwendu;
        [Description(Name = "炉膛出口温度", Unit = "℃")]
        public int LuTangChuKouWenDu { get { return lutangchukouwendu; } }
        [Byte(ByteIndex = 9)]
        public void SetLuTangChuKouWenDu(int data)
        {
            lutangchukouwendu = data;
        }
        private int lubiwendu;
        [Description(Name = "炉壁温度", Unit = "℃")]
        public int LuBiWenDu { get { return lubiwendu; } }
        [Byte(ByteIndex = 10)]
        public void SetLuBiWenDu(int data)
        {
            lubiwendu = data;
        }
        private int ranliaowendu;
        [Description(Name = "燃料温度", Unit = "℃")]
        public int RanLiaoWenDu { get { return ranliaowendu; } }
        [Byte(ByteIndex = 11)]
        public void SetRanLiaoWenDu(int data)
        {
            ranliaowendu = data;
        }
        private int kongyuqichukourefengwendu;
        [Description(Name = "空预器出口热风温度", Unit = "℃")]
        public int KongYuQiChuKouReFengWenDu { get { return kongyuqichukourefengwendu; } }
        [Byte(ByteIndex = 12)]
        public void SetKongYuQiChuKouReFengWenDu(int data)
        {
            kongyuqichukourefengwendu = data;
        }
        private int fuyazhengqiwendu;
        [Description(Name = "负压蒸汽温度", Unit = "℃")]
        public int FuYaZhengQiWenDu { get { return fuyazhengqiwendu; } }
        [Byte(ByteIndex = 13)]
        public void SetFuYaZhengQiWenDu(int data)
        {
            fuyazhengqiwendu = data;
        }
        private int guorezhengqiwendu;
        [Description(Name = "过热蒸汽温度", Unit = "℃")]
        public int GuoReZhengQiWenDu { get { return guorezhengqiwendu; } }
        [Byte(ByteIndex = 14)]
        public void SetGuoReZhengQiWenDu(int data)
        {
            guorezhengqiwendu = data;
        }
        private int huilu1wendu;
        [Description(Name = "回路1温度", Unit = "℃")]
        public int HuiLu1WenDu { get { return huilu1wendu; } }
        [Byte(ByteIndex = 15)]
        public void SetHuiLu1WenDu(int data)
        {
            huilu1wendu = data;
        }
        private int huilu2wendu;
        [Description(Name = "回路2温度", Unit = "℃")]
        public int HuiLu2WenDu { get { return huilu2wendu; } }
        [Byte(ByteIndex = 16)]
        public void SetHuiLu2WenDu(int data)
        {
            huilu2wendu = data;
        }
        private int huilu3wendu;
        [Description(Name = "回路3温度", Unit = "℃")]
        public int HuiLu3WenDu { get { return huilu3wendu; } }
        [Byte(ByteIndex = 17)]
        public void SetHuiLu3WenDu(int data)
        {
            huilu3wendu = data;
        }
        private int huilu4wendu;
        [Description(Name = "回路4温度", Unit = "℃")]
        public int HuiLu4WenDu { get { return huilu4wendu; } }
        [Byte(ByteIndex = 18)]
        public void SetHuiLu4WenDu(int data)
        {
            huilu4wendu = data;
        }
        private int huilu5wendu;
        [Description(Name = "回路5温度", Unit = "℃")]
        public int HuiLu5WenDu { get { return huilu5wendu; } }
        [Byte(ByteIndex = 19)]
        public void SetHuiLu5WenDu(int data)
        {
            huilu5wendu = data;
        }
        private int shiwaiwendu;
        [Description(Name = "室外温度", Unit = "℃")]
        public int ShiWaiWenDu { get { return shiwaiwendu; } }
        [Byte(ByteIndex = 20)]
        public void SetShiWaiWenDu(int data)
        {
            shiwaiwendu = data;
        }
        private int zhengqiyali;
        [Description(Name = "蒸汽压力", Unit = "MPa")]
        public int ZhengQiYaLi { get { return zhengqiyali; } }
        [Byte(ByteIndex = 21)]
        public void SetZhengQiYaLi(int data)
        {
            zhengqiyali = data / 100;
        }
        private int jishuiyali;
        [Description(Name = "给水压力", Unit = "MPa")]
        public int JiShuiYaLi { get { return jishuiyali; } }
        [Byte(ByteIndex = 22)]
        public void SetJiShuiYaLi(int data)
        {
            jishuiyali = data / 100;
        }
        private int chukouyali;
        [Description(Name = "出口压力", Unit = "MPa")]
        public int ChuKouYaLi { get { return chukouyali; } }
        [Byte(ByteIndex = 23)]
        public void SetChuKouYaLi(int data)
        {
            chukouyali = data / 100;
        }
        private int rukouyali;
        [Description(Name = "入口压力", Unit = "MPa")]
        public int RuKouYaLi { get { return rukouyali; } }
        [Byte(ByteIndex = 24)]
        public void SetRuKouYaLi(int data)
        {
            rukouyali = data / 100;
        }
        private int lutangyali;
        [Description(Name = "炉膛压力", Unit = "Pa")]
        public int LuTangYaLi { get { return lutangyali; } }
        [Byte(ByteIndex = 25)]
        public void SetLuTangYaLi(int data)
        {
            lutangyali = data;
        }
        private int lutangchukouyali;
        [Description(Name = "炉膛出口压力", Unit = "Pa")]
        public int LuTangChuKouYaLi { get { return lutangchukouyali; } }
        [Byte(ByteIndex = 26)]
        public void SetLuTangChuKouYaLi(int data)
        {
            lutangchukouyali = data;
        }
        private int ranqiyali;
        [Description(Name = "燃气压力", Unit = "kPa")]
        public int RanQiYaLi { get { return ranqiyali; } }
        [Byte(ByteIndex = 27)]
        public void SetRanQiYaLi(int data)
        {
            ranqiyali = data;
        }
        private int yicifengya;
        [Description(Name = "一次风压", Unit = "kPa")]
        public int YiCiFengYa { get { return yicifengya; } }
        [Byte(ByteIndex = 28)]
        public void SetYiCiFengYa(int data)
        {
            yicifengya = data;
        }
        private int ecifengya;
        [Description(Name = "二次风压", Unit = "kPa")]
        public int ECiFengYa { get { return ecifengya; } }
        [Byte(ByteIndex = 29)]
        public void SetECiFengYa(int data)
        {
            ecifengya = data;
        }
        private int shunshiranliaoliang;
        [Description(Name = "瞬时燃料量")]
        public int ShunShiRanLiaoLiang { get { return shunshiranliaoliang; } }
        [Byte(ByteIndex = 30)]
        public void SetShunShiRanLiaoLiang(int data)
        {
            shunshiranliaoliang = data;
        }
        private int shunshizhengqiliuliang;
        [Description(Name = "瞬时蒸汽流量")]
        public int ShunShiZhengQiLiuLiang { get { return shunshizhengqiliuliang; } }
        [Byte(ByteIndex = 31)]
        public void SetShunShiZhengQiLiuLiang(int data)
        {
            shunshizhengqiliuliang = data;
        }
        private int shunshijishuiliuliang;
        [Description(Name = "瞬时给水流量")]
        public int ShunShiJiShuiLiuLiang { get { return shunshijishuiliuliang; } }
        [Byte(ByteIndex = 32)]
        public void SetShunShiJiShuiLiuLiang(int data)
        {
            shunshijishuiliuliang = data;
        }
        private int shunshixunhuanliuliang;
        [Description(Name = "瞬时循环流量")]
        public int ShunShiXunHuanLiuLiang { get { return shunshixunhuanliuliang; } }
        [Byte(ByteIndex = 33)]
        public void SetShunShiXunHuanLiuLiang(int data)
        {
            shunshixunhuanliuliang = data;
        }
        private int shunshibushuiliuliang;
        [Description(Name = "瞬时补水流量")]
        public int ShunShiBuShuiLiuLiang { get { return shunshibushuiliuliang; } }
        [Byte(ByteIndex = 34)]
        public void SetShunShiBuShuiLiuLiang(int data)
        {
            shunshibushuiliuliang = data;
        }
        private int guoluyewei;
        [Description(Name = "锅炉液位", Unit = "mm")]
        public int GuoLuYeWei { get { return guoluyewei; } }
        [Byte(ByteIndex = 35)]
        public void SetGuoLuYeWei(int data)
        {
            guoluyewei = data;
        }
        private int shuixiangyewei;
        [Description(Name = "水箱液位", Unit = "mm")]
        public int ShuiXiangYeWei { get { return shuixiangyewei; } }
        [Byte(ByteIndex = 36)]
        public void SetShuiXiangYeWei(int data)
        {
            shuixiangyewei = data;
        }
        private int paiyanyanghanliang;
        [Description(Name = "排烟氧含量", Unit = "%")]
        public int PaiYanYangHanLiang { get { return paiyanyanghanliang; } }
        [Byte(ByteIndex = 37)]
        public void SetPaiYanYangHanLiang(int data)
        {
            paiyanyanghanliang = data / 10;
        }
        private int lupaisudufankui;
        [Description(Name = "炉排速度反馈", Unit = "%")]
        public int LuPaiSuDuFanKui { get { return lupaisudufankui; } }
        [Byte(ByteIndex = 38)]
        public void SetLuPaiSuDuFanKui(int data)
        {
            lupaisudufankui = data;
        }
        private int yinfengshuchufankui;
        [Description(Name = "引风输出反馈", Unit = "%")]
        public int YinFengShuChuFanKui { get { return yinfengshuchufankui; } }
        [Byte(ByteIndex = 39)]
        public void SetYinFengShuChuFanKui(int data)
        {
            yinfengshuchufankui = data;
        }
        private int gufengshuchufankui;
        [Description(Name = "鼓风输出反馈", Unit = "%")]
        public int GuFengShuChuFanKui { get { return gufengshuchufankui; } }
        [Byte(ByteIndex = 40)]
        public void SetGuFengShuChuFanKui(int data)
        {
            gufengshuchufankui = data;
        }
        private int jishuishuchufankui;
        [Description(Name = "给水输出反馈", Unit = "%")]
        public int JiShuiShuChuFanKui { get { return jishuishuchufankui; } }
        [Byte(ByteIndex = 41)]
        public void SetJiShuiShuChuFanKui(int data)
        {
            jishuishuchufankui = data;
        }
    }
}
