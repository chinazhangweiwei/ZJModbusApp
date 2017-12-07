using System;
using ZJModbus.App.Attributes;


namespace ZJModbus.App.Entities
{
    public class DOEntity
    {
        public static readonly byte[] DATA_CMD = new byte[] { 0x0, 0x3, 0x4, 0x0, 0x0, 0x38 };
        private bool GetBoolean(int data)
        {
            return data == 0xaaaa;
        }
        private bool ranshaoqiqiting;
        [Description(Name = "燃烧器启停")]
        public bool RanShaoQiQiTing { get { return ranshaoqiqiting; } }
        [Byte(ByteIndex = 0)]
        public void SetRanShaoQiQiTing(int data)
        {
            ranshaoqiqiting = GetBoolean(data);
        }
        private bool ranshaoqidahuo;
        [Description(Name = "燃烧器大火")]
        public bool RanShaoQiDaHuo { get { return ranshaoqidahuo; } }
        [Byte(ByteIndex = 1)]
        public void SetRanShaoQiDaHuo(int data)
        {
            ranshaoqidahuo = GetBoolean(data);
        }
        private bool ranshaoqisanduanhuo;
        [Description(Name = "燃烧器三段火")]
        public bool RanShaoQiSanDuanHuo { get { return ranshaoqisanduanhuo; } }
        [Byte(ByteIndex = 2)]
        public void SetRanShaoQiSanDuanHuo(int data)
        {
            ranshaoqisanduanhuo = GetBoolean(data);
        }
        private bool ranshaoqihuolizengjia;
        [Description(Name = "燃烧器火力增加")]
        public bool RanShaoQiHuoLiZengJia { get { return ranshaoqihuolizengjia; } }
        [Byte(ByteIndex = 3)]
        public void SetRanShaoQiHuoLiZengJia(int data)
        {
            ranshaoqihuolizengjia = GetBoolean(data);
        }
        private bool ranshaoqihuolijianshao;
        [Description(Name = "燃烧器火力减少")]
        public bool RanShaoQiHuoLiJianShao { get { return ranshaoqihuolijianshao; } }
        [Byte(ByteIndex = 4)]
        public void SetRanShaoQiHuoLiJianShao(int data)
        {
            ranshaoqihuolijianshao = GetBoolean(data);
        }
        private bool jishuibeng;
        [Description(Name = "给水泵（主）")]
        public bool JiShuiBeng { get { return jishuibeng; } }
        [Byte(ByteIndex = 5)]
        public void SetJiShuiBeng(int data)
        {
            jishuibeng = GetBoolean(data);
        }
        private bool jishuibengbei;
        [Description(Name = "给水泵（备）")]
        public bool JiShuiBengBei { get { return jishuibengbei; } }
        [Byte(ByteIndex = 6)]
        public void SetJiShuiBengBei(int data)
        {
            jishuibengbei = GetBoolean(data);
        }
        private bool jishuiliangzengjia;
        [Description(Name = "给水量增加")]
        public bool JiShuiLiangZengJia { get { return jishuiliangzengjia; } }
        [Byte(ByteIndex = 7)]
        public void SetJiShuiLiangZengJia(int data)
        {
            jishuiliangzengjia = GetBoolean(data);
        }
        private bool jishuiliangjianshao;
        [Description(Name = "给水量减少")]
        public bool JiShuiLiangJianShao { get { return jishuiliangjianshao; } }
        [Byte(ByteIndex = 8)]
        public void SetJiShuiLiangJianShao(int data)
        {
            jishuiliangjianshao = GetBoolean(data);
        }
        private bool xunhuanbeng;
        [Description(Name = "循环泵（主）")]
        public bool XunHuanBeng { get { return xunhuanbeng; } }
        [Byte(ByteIndex = 9)]
        public void SetXunHuanBeng(int data)
        {
            xunhuanbeng = GetBoolean(data);
        }
        private bool xunhuanbengbei;
        [Description(Name = "循环泵（备）")]
        public bool XunHuanBengBei { get { return xunhuanbengbei; } }
        [Byte(ByteIndex = 10)]
        public void SetXunHuanBengBei(int data)
        {
            xunhuanbengbei = GetBoolean(data);
        }
        private bool baojingshuchu;
        [Description(Name = "报警输出")]
        public bool BaoJingShuChu { get { return baojingshuchu; } }
        [Byte(ByteIndex = 11)]
        public void SetBaoJingShuChu(int data)
        {
            baojingshuchu = GetBoolean(data);
        }
        private bool jiarezu1;
        [Description(Name = "加热组1")]
        public bool JiaReZu1 { get { return jiarezu1; } }
        [Byte(ByteIndex = 12)]
        public void SetJiaReZu1(int data)
        {
            jiarezu1 = GetBoolean(data);
        }
        private bool jiarezu2;
        [Description(Name = "加热组2")]
        public bool JiaReZu2 { get { return jiarezu2; } }
        [Byte(ByteIndex = 13)]
        public void SetJiaReZu2(int data)
        {
            jiarezu2 = GetBoolean(data);
        }
        private bool jiarezu3;
        [Description(Name = "加热组3")]
        public bool JiaReZu3 { get { return jiarezu3; } }
        [Byte(ByteIndex = 14)]
        public void SetJiaReZu3(int data)
        {
            jiarezu3 = GetBoolean(data);
        }
        private bool jiarezu4;
        [Description(Name = "加热组4")]
        public bool JiaReZu4 { get { return jiarezu4; } }
        [Byte(ByteIndex = 15)]
        public void SetJiaReZu4(int data)
        {
            jiarezu4 = GetBoolean(data);
        }
        private bool jiarezu5;
        [Description(Name = "加热组5")]
        public bool JiaReZu5 { get { return jiarezu5; } }
        [Byte(ByteIndex = 16)]
        public void SetJiaReZu5(int data)
        {
            jiarezu5 = GetBoolean(data);
        }
        private bool jiarezu6;
        [Description(Name = "加热组6")]
        public bool JiaReZu6 { get { return jiarezu6; } }
        [Byte(ByteIndex = 17)]
        public void SetJiaReZu6(int data)
        {
            jiarezu6 = GetBoolean(data);
        }
        private bool jiarezu7;
        [Description(Name = "加热组7")]
        public bool JiaReZu7 { get { return jiarezu7; } }
        [Byte(ByteIndex = 18)]
        public void SetJiaReZu7(int data)
        {
            jiarezu7 = GetBoolean(data);
        }
        private bool jiarezu8;
        [Description(Name = "加热组8")]
        public bool JiaReZu8 { get { return jiarezu8; } }
        [Byte(ByteIndex = 19)]
        public void SetJiaReZu8(int data)
        {
            jiarezu8 = GetBoolean(data);
        }
        private bool jiarezu9;
        [Description(Name = "加热组9")]
        public bool JiaReZu9 { get { return jiarezu9; } }
        [Byte(ByteIndex = 20)]
        public void SetJiaReZu9(int data)
        {
            jiarezu9 = GetBoolean(data);
        }
        private bool jiarezu10;
        [Description(Name = "加热组10")]
        public bool JiaReZu10 { get { return jiarezu10; } }
        [Byte(ByteIndex = 21)]
        public void SetJiaReZu10(int data)
        {
            jiarezu10 = GetBoolean(data);
        }
        private bool jiarezu11;
        [Description(Name = "加热组11")]
        public bool JiaReZu11 { get { return jiarezu11; } }
        [Byte(ByteIndex = 22)]
        public void SetJiaReZu11(int data)
        {
            jiarezu11 = GetBoolean(data);
        }
        private bool jiarezu12;
        [Description(Name = "加热组12")]
        public bool JiaReZu12 { get { return jiarezu12; } }
        [Byte(ByteIndex = 23)]
        public void SetJiaReZu12(int data)
        {
            jiarezu12 = GetBoolean(data);
        }
        private bool jiarezu13;
        [Description(Name = "加热组13")]
        public bool JiaReZu13 { get { return jiarezu13; } }
        [Byte(ByteIndex = 24)]
        public void SetJiaReZu13(int data)
        {
            jiarezu13 = GetBoolean(data);
        }
        private bool jiarezu14;
        [Description(Name = "加热组14")]
        public bool JiaReZu14 { get { return jiarezu14; } }
        [Byte(ByteIndex = 25)]
        public void SetJiaReZu14(int data)
        {
            jiarezu14 = GetBoolean(data);
        }
        private bool jiarezu15;
        [Description(Name = "加热组15")]
        public bool JiaReZu15 { get { return jiarezu15; } }
        [Byte(ByteIndex = 26)]
        public void SetJiaReZu15(int data)
        {
            jiarezu15 = GetBoolean(data);
        }
        private bool jiarezu16;
        [Description(Name = "加热组16")]
        public bool JiaReZu16 { get { return jiarezu16; } }
        [Byte(ByteIndex = 27)]
        public void SetJiaReZu16(int data)
        {
            jiarezu16 = GetBoolean(data);
        }
        private bool jiarezu17;
        [Description(Name = "加热组17")]
        public bool JiaReZu17 { get { return jiarezu17; } }
        [Byte(ByteIndex = 28)]
        public void SetJiaReZu17(int data)
        {
            jiarezu17 = GetBoolean(data);
        }
        private bool jiarezu18;
        [Description(Name = "加热组18")]
        public bool JiaReZu18 { get { return jiarezu18; } }
        [Byte(ByteIndex = 29)]
        public void SetJiaReZu18(int data)
        {
            jiarezu18 = GetBoolean(data);
        }
        private bool jiarezu19;
        [Description(Name = "加热组19")]
        public bool JiaReZu19 { get { return jiarezu19; } }
        [Byte(ByteIndex = 30)]
        public void SetJiaReZu19(int data)
        {
            jiarezu19 = GetBoolean(data);
        }
        private bool jiarezu20;
        [Description(Name = "加热组20")]
        public bool JiaReZu20 { get { return jiarezu20; } }
        [Byte(ByteIndex = 31)]
        public void SetJiaReZu20(int data)
        {
            jiarezu20 = GetBoolean(data);
        }
        private bool jiarezu21;
        [Description(Name = "加热组21")]
        public bool JiaReZu21 { get { return jiarezu21; } }
        [Byte(ByteIndex = 32)]
        public void SetJiaReZu21(int data)
        {
            jiarezu21 = GetBoolean(data);
        }
        private bool jiarezu22;
        [Description(Name = "加热组22")]
        public bool JiaReZu22 { get { return jiarezu22; } }
        [Byte(ByteIndex = 33)]
        public void SetJiaReZu22(int data)
        {
            jiarezu22 = GetBoolean(data);
        }
        private bool jiarezu23;
        [Description(Name = "加热组23")]
        public bool JiaReZu23 { get { return jiarezu23; } }
        [Byte(ByteIndex = 34)]
        public void SetJiaReZu23(int data)
        {
            jiarezu23 = GetBoolean(data);
        }
        private bool jiarezu24;
        [Description(Name = "加热组24")]
        public bool JiaReZu24 { get { return jiarezu24; } }
        [Byte(ByteIndex = 35)]
        public void SetJiaReZu24(int data)
        {
            jiarezu24 = GetBoolean(data);
        }
        private bool jiarezu25;
        [Description(Name = "加热组25")]
        public bool JiaReZu25 { get { return jiarezu25; } }
        [Byte(ByteIndex = 36)]
        public void SetJiaReZu25(int data)
        {
            jiarezu25 = GetBoolean(data);
        }
        private bool jiarezu26;
        [Description(Name = "加热组26")]
        public bool JiaReZu26 { get { return jiarezu26; } }
        [Byte(ByteIndex = 37)]
        public void SetJiaReZu26(int data)
        {
            jiarezu26 = GetBoolean(data);
        }
        private bool jiarezu27;
        [Description(Name = "加热组27")]
        public bool JiaReZu27 { get { return jiarezu27; } }
        [Byte(ByteIndex = 38)]
        public void SetJiaReZu27(int data)
        {
            jiarezu27 = GetBoolean(data);
        }
        private bool jiarezu28;
        [Description(Name = "加热组28")]
        public bool JiaReZu28 { get { return jiarezu28; } }
        [Byte(ByteIndex = 39)]
        public void SetJiaReZu28(int data)
        {
            jiarezu28 = GetBoolean(data);
        }
        private bool jiarezu29;
        [Description(Name = "加热组29")]
        public bool JiaReZu29 { get { return jiarezu29; } }
        [Byte(ByteIndex = 40)]
        public void SetJiaReZu29(int data)
        {
            jiarezu29 = GetBoolean(data);
        }
        private bool jiarezu30;
        [Description(Name = "加热组30")]
        public bool JiaReZu30 { get { return jiarezu30; } }
        [Byte(ByteIndex = 41)]
        public void SetJiaReZu30(int data)
        {
            jiarezu30 = GetBoolean(data);
        }
        private bool yinfengji;
        [Description(Name = "引风机")]
        public bool YinFengJi { get { return yinfengji; } }
        [Byte(ByteIndex = 42)]
        public void SetYinFengJi(int data)
        {
            yinfengji = GetBoolean(data);
        }
        private bool yinfengliangzengjia;
        [Description(Name = "引风量增加")]
        public bool YinFengLiangZengJia { get { return yinfengliangzengjia; } }
        [Byte(ByteIndex = 43)]
        public void SetYinFengLiangZengJia(int data)
        {
            yinfengliangzengjia = GetBoolean(data);
        }
        private bool yinfengliangjianshao;
        [Description(Name = "引风量减少")]
        public bool YinFengLiangJianShao { get { return yinfengliangjianshao; } }
        [Byte(ByteIndex = 44)]
        public void SetYinFengLiangJianShao(int data)
        {
            yinfengliangjianshao = GetBoolean(data);
        }
        private bool gufengji;
        [Description(Name = "鼓风机")]
        public bool GuFengJi { get { return gufengji; } }
        [Byte(ByteIndex = 45)]
        public void SetGuFengJi(int data)
        {
            gufengji = GetBoolean(data);
        }
        private bool gufengliangzengjia;
        [Description(Name = "鼓风量增加")]
        public bool GuFengLiangZengJia { get { return gufengliangzengjia; } }
        [Byte(ByteIndex = 46)]
        public void SetGuFengLiangZengJia(int data)
        {
            gufengliangzengjia = GetBoolean(data);
        }
        private bool gufengliangjianshao;
        [Description(Name = "鼓风量减少")]
        public bool GuFengLiangJianShao { get { return gufengliangjianshao; } }
        [Byte(ByteIndex = 47)]
        public void SetGuFengLiangJianShao(int data)
        {
            gufengliangjianshao = GetBoolean(data);
        }
        private bool ecigufengji;
        [Description(Name = "二次鼓风机")]
        public bool ECiGuFengJi { get { return ecigufengji; } }
        [Byte(ByteIndex = 48)]
        public void SetECiGuFengJi(int data)
        {
            ecigufengji = GetBoolean(data);
        }
        private bool ecigufengliangzengjia;
        [Description(Name = "二次鼓风量增加")]
        public bool ECiGuFengLiangZengJia { get { return ecigufengliangzengjia; } }
        [Byte(ByteIndex = 49)]
        public void SetECiGuFengLiangZengJia(int data)
        {
            ecigufengliangzengjia = GetBoolean(data);
        }
        private bool ecigufengliangjianshao;
        [Description(Name = "二次鼓风量减少")]
        public bool ECiGuFengLiangJianShao { get { return ecigufengliangjianshao; } }
        [Byte(ByteIndex = 50)]
        public void SetECiGuFengLiangJianShao(int data)
        {
            ecigufengliangjianshao = GetBoolean(data);
        }
        private bool lupaihuojinliaojizhengzhuan;
        [Description(Name = "炉排或进料机正转")]
        public bool LuPaiHuoJinLiaoJiZhengZhuan { get { return lupaihuojinliaojizhengzhuan; } }
        [Byte(ByteIndex = 51)]
        public void SetLuPaiHuoJinLiaoJiZhengZhuan(int data)
        {
            lupaihuojinliaojizhengzhuan = GetBoolean(data);
        }
        private bool lupaifanzhuan;
        [Description(Name = "炉排反转")]
        public bool LuPaiFanZhuan { get { return lupaifanzhuan; } }
        [Byte(ByteIndex = 52)]
        public void SetLuPaiFanZhuan(int data)
        {
            lupaifanzhuan = GetBoolean(data);
        }
        private bool chuzhaji;
        [Description(Name = "出渣机")]
        public bool ChuZhaJi { get { return chuzhaji; } }
        [Byte(ByteIndex = 53)]
        public void SetChuZhaJi(int data)
        {
            chuzhaji = GetBoolean(data);
        }
        private bool dianhuoqi;
        [Description(Name = "点火器")]
        public bool DianHuoQi { get { return dianhuoqi; } }
        [Byte(ByteIndex = 54)]
        public void SetDianHuoQi(int data)
        {
            dianhuoqi = GetBoolean(data);
        }
        private bool jiayaobeng;
        [Description(Name = "加药泵")]
        public bool JiaYaoBeng { get { return jiayaobeng; } }
        [Byte(ByteIndex = 55)]
        public void SetJiaYaoBeng(int data)
        {
            jiayaobeng = GetBoolean(data);
        }
        private bool paiwufa;
        [Description(Name = "排污阀")]
        public bool PaiWuFa { get { return paiwufa; } }
        [Byte(ByteIndex = 56)]
        public void SetPaiWuFa(int data)
        {
            paiwufa = GetBoolean(data);
        }
    }
}
