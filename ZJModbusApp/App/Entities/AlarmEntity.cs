using System;
using ZJModbus.App.Attributes;

namespace ZJModbus.App.Entities
{
    public class AlarmEntity
    {
        private bool GetBoolean(int data)
        {
            return data == 0xaaaa;
        }

        private bool paiyanwendugao;
        [Description(Name = "排烟温度高")]
        public bool PaiYanWenDuGao { get { return paiyanwendugao; } }
        [Byte(ByteIndex = 0)]
        public void SetPaiYanWenDuGao(int data)
        {
            paiyanwendugao = GetBoolean(data);
        }
        private bool lushuiwendugao;
        [Description(Name = "炉水温度高")]
        public bool LuShuiWenDuGao { get { return lushuiwendugao; } }
        [Byte(ByteIndex = 1)]
        public void SetLuShuiWenDuGao(int data)
        {
            lushuiwendugao = GetBoolean(data);
        }
        private bool chukouwendugao;
        [Description(Name = "出口温度高")]
        public bool ChuKouWenDuGao { get { return chukouwendugao; } }
        [Byte(ByteIndex = 2)]
        public void SetChuKouWenDuGao(int data)
        {
            chukouwendugao = GetBoolean(data);
        }
        private bool chaoya;
        [Description(Name = "超压")]
        public bool ChaoYa { get { return chaoya; } }
        [Byte(ByteIndex = 3)]
        public void SetChaoYa(int data)
        {
            chaoya = GetBoolean(data);
        }
        private bool jixiandishuiwei;
        [Description(Name = "极限低水位")]
        public bool JiXianDiShuiWei { get { return jixiandishuiwei; } }
        [Byte(ByteIndex = 4)]
        public void SetJiXianDiShuiWei(int data)
        {
            jixiandishuiwei = GetBoolean(data);
        }
        private bool dishuiwei;
        [Description(Name = "低水位")]
        public bool DiShuiWei { get { return dishuiwei; } }
        [Byte(ByteIndex = 5)]
        public void SetDiShuiWei(int data)
        {
            dishuiwei = GetBoolean(data);
        }
        private bool gaoshuiwei;
        [Description(Name = "高水位")]
        public bool GaoShuiWei { get { return gaoshuiwei; } }
        [Byte(ByteIndex = 6)]
        public void SetGaoShuiWei(int data)
        {
            gaoshuiwei = GetBoolean(data);
        }
        private bool shuiweixinhaoluojicuo;
        [Description(Name = "水位信号逻辑错")]
        public bool ShuiWeiXinHaoLuoJiCuo { get { return shuiweixinhaoluojicuo; } }
        [Byte(ByteIndex = 7)]
        public void SetShuiWeiXinHaoLuoJiCuo(int data)
        {
            shuiweixinhaoluojicuo = GetBoolean(data);
        }
        private bool lubiwendugao;
        [Description(Name = "炉壁温度高")]
        public bool LuBiWenDuGao { get { return lubiwendugao; } }
        [Byte(ByteIndex = 8)]
        public void SetLuBiWenDuGao(int data)
        {
            lubiwendugao = GetBoolean(data);
        }
        private bool fuyazhengqiwendugao;
        [Description(Name = "负压蒸汽温度高")]
        public bool FuYaZhengQiWenDuGao { get { return fuyazhengqiwendugao; } }
        [Byte(ByteIndex = 9)]
        public void SetFuYaZhengQiWenDuGao(int data)
        {
            fuyazhengqiwendugao = GetBoolean(data);
        }
        private bool ranshaoqiguzhang;
        [Description(Name = "燃烧器故障")]
        public bool RanShaoQiGuZhang { get { return ranshaoqiguzhang; } }
        [Byte(ByteIndex = 10)]
        public void SetRanShaoQiGuZhang(int data)
        {
            ranshaoqiguzhang = GetBoolean(data);
        }
        private bool ranqixielou;
        [Description(Name = "燃气泄漏")]
        public bool RanQiXieLou { get { return ranqixielou; } }
        [Byte(ByteIndex = 11)]
        public void SetRanQiXieLou(int data)
        {
            ranqixielou = GetBoolean(data);
        }
        private bool ranqiyalidi;
        [Description(Name = "燃气压力低")]
        public bool RanQiYaLiDi { get { return ranqiyalidi; } }
        [Byte(ByteIndex = 12)]
        public void SetRanQiYaLiDi(int data)
        {
            ranqiyalidi = GetBoolean(data);
        }
        private bool ranqiyaliyichang;
        [Description(Name = "燃气压力异常")]
        public bool RanQiYaLiYiChang { get { return ranqiyaliyichang; } }
        [Byte(ByteIndex = 13)]
        public void SetRanQiYaLiYiChang(int data)
        {
            ranqiyaliyichang = GetBoolean(data);
        }
        private bool ranqiyaligao;
        [Description(Name = "燃气压力高")]
        public bool RanQiYaLiGao { get { return ranqiyaligao; } }
        [Byte(ByteIndex = 14)]
        public void SetRanQiYaLiGao(int data)
        {
            ranqiyaligao = GetBoolean(data);
        }
        private bool jishuibianpinqiguzhang;
        [Description(Name = "给水变频器故障")]
        public bool JiShuiBianPinQiGuZhang { get { return jishuibianpinqiguzhang; } }
        [Byte(ByteIndex = 15)]
        public void SetJiShuiBianPinQiGuZhang(int data)
        {
            jishuibianpinqiguzhang = GetBoolean(data);
        }
        private bool xunhuanbianpinqiguzhang;
        [Description(Name = "循环变频器故障")]
        public bool XunHuanBianPinQiGuZhang { get { return xunhuanbianpinqiguzhang; } }
        [Byte(ByteIndex = 16)]
        public void SetXunHuanBianPinQiGuZhang(int data)
        {
            xunhuanbianpinqiguzhang = GetBoolean(data);
        }
        private bool yinfengbianpinqiguzhang;
        [Description(Name = "引风变频器故障")]
        public bool YinFengBianPinQiGuZhang { get { return yinfengbianpinqiguzhang; } }
        [Byte(ByteIndex = 17)]
        public void SetYinFengBianPinQiGuZhang(int data)
        {
            yinfengbianpinqiguzhang = GetBoolean(data);
        }
        private bool gufengbianpinqiguzhang;
        [Description(Name = "鼓风变频器故障")]
        public bool GuFengBianPinQiGuZhang { get { return gufengbianpinqiguzhang; } }
        [Byte(ByteIndex = 18)]
        public void SetGuFengBianPinQiGuZhang(int data)
        {
            gufengbianpinqiguzhang = GetBoolean(data);
        }
        private bool ecigufengbianpinqiguzhang;
        [Description(Name = "二次鼓风变频器故障")]
        public bool ECiGuFengBianPinQiGuZhang { get { return ecigufengbianpinqiguzhang; } }
        [Byte(ByteIndex = 19)]
        public void SetECiGuFengBianPinQiGuZhang(int data)
        {
            ecigufengbianpinqiguzhang = GetBoolean(data);
        }
        private bool lupaibianpinqiguzhang;
        [Description(Name = "炉排变频器故障")]
        public bool LuPaiBianPinQiGuZhang { get { return lupaibianpinqiguzhang; } }
        [Byte(ByteIndex = 20)]
        public void SetLuPaiBianPinQiGuZhang(int data)
        {
            lupaibianpinqiguzhang = GetBoolean(data);
        }
        private bool jishuibengguzhang;
        [Description(Name = "给水泵故障")]
        public bool JiShuiBengGuZhang { get { return jishuibengguzhang; } }
        [Byte(ByteIndex = 21)]
        public void SetJiShuiBengGuZhang(int data)
        {
            jishuibengguzhang = GetBoolean(data);
        }
        private bool xunhuanbengguzhang;
        [Description(Name = "循环泵故障")]
        public bool XunHuanBengGuZhang { get { return xunhuanbengguzhang; } }
        [Byte(ByteIndex = 22)]
        public void SetXunHuanBengGuZhang(int data)
        {
            xunhuanbengguzhang = GetBoolean(data);
        }
        private bool xunhuanxitongqianya;
        [Description(Name = "循环系统欠压")]
        public bool XunHuanXiTongQianYa { get { return xunhuanxitongqianya; } }
        [Byte(ByteIndex = 23)]
        public void SetXunHuanXiTongQianYa(int data)
        {
            xunhuanxitongqianya = GetBoolean(data);
        }
        private bool didianya;
        [Description(Name = "低电压")]
        public bool DiDianYa { get { return didianya; } }
        [Byte(ByteIndex = 24)]
        public void SetDiDianYa(int data)
        {
            didianya = GetBoolean(data);
        }
        private bool gaodianya;
        [Description(Name = "高电压")]
        public bool GaoDianYa { get { return gaodianya; } }
        [Byte(ByteIndex = 25)]
        public void SetGaoDianYa(int data)
        {
            gaodianya = GetBoolean(data);
        }
        private bool quexiang;
        [Description(Name = "缺相")]
        public bool QueXiang { get { return quexiang; } }
        [Byte(ByteIndex = 26)]
        public void SetQueXiang(int data)
        {
            quexiang = GetBoolean(data);
        }
        private bool loudian;
        [Description(Name = "漏电")]
        public bool LouDian { get { return loudian; } }
        [Byte(ByteIndex = 27)]
        public void SetLouDian(int data)
        {
            loudian = GetBoolean(data);
        }
        private bool biansongqiguoyabaohu;
        [Description(Name = "变送器过压保护")]
        public bool BianSongQiGuoYaBaoHu { get { return biansongqiguoyabaohu; } }
        [Byte(ByteIndex = 28)]
        public void SetBianSongQiGuoYaBaoHu(int data)
        {
            biansongqiguoyabaohu = GetBoolean(data);
        }
        private bool guanjiancanshuyichang;
        [Description(Name = "关键参数异常")]
        public bool GuanJianCanShuYiChang { get { return guanjiancanshuyichang; } }
        [Byte(ByteIndex = 29)]
        public void SetGuanJianCanShuYiChang(int data)
        {
            guanjiancanshuyichang = GetBoolean(data);
        }
        private bool shedingcanshuyichang;
        [Description(Name = "设定参数异常")]
        public bool SheDingCanShuYiChang { get { return shedingcanshuyichang; } }
        [Byte(ByteIndex = 30)]
        public void SetSheDingCanShuYiChang(int data)
        {
            shedingcanshuyichang = GetBoolean(data);
        }
        private bool shizhongguzhang;
        [Description(Name = "时钟故障")]
        public bool ShiZhongGuZhang { get { return shizhongguzhang; } }
        [Byte(ByteIndex = 31)]
        public void SetShiZhongGuZhang(int data)
        {
            shizhongguzhang = GetBoolean(data);
        }
        private bool cunchuqiguzhang;
        [Description(Name = "存储器故障")]
        public bool CunChuQiGuZhang { get { return cunchuqiguzhang; } }
        [Byte(ByteIndex = 32)]
        public void SetCunChuQiGuZhang(int data)
        {
            cunchuqiguzhang = GetBoolean(data);
        }
        private bool waibuliansuo;
        [Description(Name = "外部连锁")]
        public bool WaiBuLianSuo { get { return waibuliansuo; } }
        [Byte(ByteIndex = 33)]
        public void SetWaiBuLianSuo(int data)
        {
            waibuliansuo = GetBoolean(data);
        }
        private bool queyou;
        [Description(Name = "缺油")]
        public bool QueYou { get { return queyou; } }
        [Byte(ByteIndex = 34)]
        public void SetQueYou(int data)
        {
            queyou = GetBoolean(data);
        }
        private bool diyouwei;
        [Description(Name = "低油位")]
        public bool DiYouWei { get { return diyouwei; } }
        [Byte(ByteIndex = 35)]
        public void SetDiYouWei(int data)
        {
            diyouwei = GetBoolean(data);
        }
        private bool bentipaiyanwendugao;
        [Description(Name = "本体排烟温度高")]
        public bool BenTiPaiYanWenDuGao { get { return bentipaiyanwendugao; } }
        [Byte(ByteIndex = 36)]
        public void SetBenTiPaiYanWenDuGao(int data)
        {
            bentipaiyanwendugao = GetBoolean(data);
        }
    }
}
