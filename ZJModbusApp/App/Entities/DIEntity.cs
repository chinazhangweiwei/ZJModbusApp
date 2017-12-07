using System;
using ZJModbus.App.Attributes;


namespace ZJModbus.App.Entities
{
    public class DIEntity
    {
        public static readonly byte[] DATA_CMD = new byte[] { 0x0, 0x3, 0x2, 0x0, 0x0, 0x2A };
        private bool GetBoolean(int data)
        {
            return data == 0xaaaa;
        }
        private bool jixiandishuiweibaojingdianji;
        [Description(Name = "极限低水位报警电极（缺水保护）")]
        public bool JiXianDiShuiWeiBaoJingDianJi { get { return jixiandishuiweibaojingdianji; } }
        [Byte(ByteIndex = 0)]
        public void SetJiXianDiShuiWeiBaoJingDianJi(int data)
        {
            jixiandishuiweibaojingdianji = GetBoolean(data);
        }
        private bool dishuiweibaojingdianji;
        [Description(Name = "低水位报警电极")]
        public bool DiShuiWeiBaoJingDianJi { get { return dishuiweibaojingdianji; } }
        [Byte(ByteIndex = 1)]
        public void SetDiShuiWeiBaoJingDianJi(int data)
        {
            dishuiweibaojingdianji = GetBoolean(data);
        }
        private bool dishuiweidianji;
        [Description(Name = "低水位电极")]
        public bool DiShuiWeiDianJi { get { return dishuiweidianji; } }
        [Byte(ByteIndex = 2)]
        public void SetDiShuiWeiDianJi(int data)
        {
            dishuiweidianji = GetBoolean(data);
        }
        private bool zhongshuiweidianji;
        [Description(Name = "中水位电极")]
        public bool ZhongShuiWeiDianJi { get { return zhongshuiweidianji; } }
        [Byte(ByteIndex = 3)]
        public void SetZhongShuiWeiDianJi(int data)
        {
            zhongshuiweidianji = GetBoolean(data);
        }
        private bool gaoshuiweidianji;
        [Description(Name = "高水位电极")]
        public bool GaoShuiWeiDianJi { get { return gaoshuiweidianji; } }
        [Byte(ByteIndex = 4)]
        public void SetGaoShuiWeiDianJi(int data)
        {
            gaoshuiweidianji = GetBoolean(data);
        }
        private bool gaoshuiweibaojingdianji;
        [Description(Name = "高水位报警电极")]
        public bool GaoShuiWeiBaoJingDianJi { get { return gaoshuiweibaojingdianji; } }
        [Byte(ByteIndex = 5)]
        public void SetGaoShuiWeiBaoJingDianJi(int data)
        {
            gaoshuiweibaojingdianji = GetBoolean(data);
        }
        private bool shuixiangdiweidianji;
        [Description(Name = "水箱低位电极")]
        public bool ShuiXiangDiWeiDianJi { get { return shuixiangdiweidianji; } }
        [Byte(ByteIndex = 6)]
        public void SetShuiXiangDiWeiDianJi(int data)
        {
            shuixiangdiweidianji = GetBoolean(data);
        }
        private bool shuixianggaoweidianji;
        [Description(Name = "水箱高位电极")]
        public bool ShuiXiangGaoWeiDianJi { get { return shuixianggaoweidianji; } }
        [Byte(ByteIndex = 7)]
        public void SetShuiXiangGaoWeiDianJi(int data)
        {
            shuixianggaoweidianji = GetBoolean(data);
        }
        private bool jixiandiyeweibaojingxinhao;
        [Description(Name = "极限低液位报警信号（干接点）")]
        public bool JiXianDiYeWeiBaoJingXinHao { get { return jixiandiyeweibaojingxinhao; } }
        [Byte(ByteIndex = 8)]
        public void SetJiXianDiYeWeiBaoJingXinHao(int data)
        {
            jixiandiyeweibaojingxinhao = GetBoolean(data);
        }
        private bool dibaojingxinhao;
        [Description(Name = "低报警信号（干接点）")]
        public bool DiBaoJingXinHao { get { return dibaojingxinhao; } }
        [Byte(ByteIndex = 9)]
        public void SetDiBaoJingXinHao(int data)
        {
            dibaojingxinhao = GetBoolean(data);
        }
        private bool kongbengxinhao;
        [Description(Name = "控泵信号（干接点）")]
        public bool KongBengXinHao { get { return kongbengxinhao; } }
        [Byte(ByteIndex = 10)]
        public void SetKongBengXinHao(int data)
        {
            kongbengxinhao = GetBoolean(data);
        }
        private bool gaobaojingxinhao;
        [Description(Name = "高报警信号（干接点）")]
        public bool GaoBaoJingXinHao { get { return gaobaojingxinhao; } }
        [Byte(ByteIndex = 11)]
        public void SetGaoBaoJingXinHao(int data)
        {
            gaobaojingxinhao = GetBoolean(data);
        }
        private bool chaoyabaojingxinhao;
        [Description(Name = "超压报警信号")]
        public bool ChaoYaBaoJingXinHao { get { return chaoyabaojingxinhao; } }
        [Byte(ByteIndex = 12)]
        public void SetChaoYaBaoJingXinHao(int data)
        {
            chaoyabaojingxinhao = GetBoolean(data);
        }
        private bool fuhediaojieyalixinhao;
        [Description(Name = "负荷调节压力信号")]
        public bool FuHeDiaoJieYaLiXinHao { get { return fuhediaojieyalixinhao; } }
        [Byte(ByteIndex = 13)]
        public void SetFuHeDiaoJieYaLiXinHao(int data)
        {
            fuhediaojieyalixinhao = GetBoolean(data);
        }
        private bool qitingkongzhiyalixinhao;
        [Description(Name = "启停控制压力信号")]
        public bool QiTingKongZhiYaLiXinHao { get { return qitingkongzhiyalixinhao; } }
        [Byte(ByteIndex = 14)]
        public void SetQiTingKongZhiYaLiXinHao(int data)
        {
            qitingkongzhiyalixinhao = GetBoolean(data);
        }
        private bool yalibiaodizhen;
        [Description(Name = "压力表低针")]
        public bool YaLiBiaoDiZhen { get { return yalibiaodizhen; } }
        [Byte(ByteIndex = 15)]
        public void SetYaLiBiaoDiZhen(int data)
        {
            yalibiaodizhen = GetBoolean(data);
        }
        private bool yalibiaogaozhen;
        [Description(Name = "压力表高针")]
        public bool YaLiBiaoGaoZhen { get { return yalibiaogaozhen; } }
        [Byte(ByteIndex = 16)]
        public void SetYaLiBiaoGaoZhen(int data)
        {
            yalibiaogaozhen = GetBoolean(data);
        }
        private bool lubichaowenxinhao;
        [Description(Name = "炉壁超温信号")]
        public bool LuBiChaoWenXinHao { get { return lubichaowenxinhao; } }
        [Byte(ByteIndex = 17)]
        public void SetLuBiChaoWenXinHao(int data)
        {
            lubichaowenxinhao = GetBoolean(data);
        }
        private bool ranshaoqiguzhangbaojingxinhao;
        [Description(Name = "燃烧器故障报警信号")]
        public bool RanShaoQiGuZhangBaoJingXinHao { get { return ranshaoqiguzhangbaojingxinhao; } }
        [Byte(ByteIndex = 18)]
        public void SetRanShaoQiGuZhangBaoJingXinHao(int data)
        {
            ranshaoqiguzhangbaojingxinhao = GetBoolean(data);
        }
        private bool ranqixieloubaojingxinhao;
        [Description(Name = "燃气泄漏报警信号")]
        public bool RanQiXieLouBaoJingXinHao { get { return ranqixieloubaojingxinhao; } }
        [Byte(ByteIndex = 19)]
        public void SetRanQiXieLouBaoJingXinHao(int data)
        {
            ranqixieloubaojingxinhao = GetBoolean(data);
        }
        private bool ranqiyalidibaojingxinhao;
        [Description(Name = "燃气压力低报警信号")]
        public bool RanQiYaLiDiBaoJingXinHao { get { return ranqiyalidibaojingxinhao; } }
        [Byte(ByteIndex = 20)]
        public void SetRanQiYaLiDiBaoJingXinHao(int data)
        {
            ranqiyalidibaojingxinhao = GetBoolean(data);
        }
        private bool ranqiyaliyichangbaojingxinhao;
        [Description(Name = "燃气压力异常报警信号")]
        public bool RanQiYaLiYiChangBaoJingXinHao { get { return ranqiyaliyichangbaojingxinhao; } }
        [Byte(ByteIndex = 21)]
        public void SetRanQiYaLiYiChangBaoJingXinHao(int data)
        {
            ranqiyaliyichangbaojingxinhao = GetBoolean(data);
        }
        private bool ranqiyaligaobaojingxinhao;
        [Description(Name = "燃气压力高报警信号")]
        public bool RanQiYaLiGaoBaoJingXinHao { get { return ranqiyaligaobaojingxinhao; } }
        [Byte(ByteIndex = 22)]
        public void SetRanQiYaLiGaoBaoJingXinHao(int data)
        {
            ranqiyaligaobaojingxinhao = GetBoolean(data);
        }
        private bool xunhuanbengdongzuofankuixinhao;
        [Description(Name = "循环泵动作反馈信号（主）")]
        public bool XunHuanBengDongZuoFanKuiXinHao { get { return xunhuanbengdongzuofankuixinhao; } }
        [Byte(ByteIndex = 23)]
        public void SetXunHuanBengDongZuoFanKuiXinHao(int data)
        {
            xunhuanbengdongzuofankuixinhao = GetBoolean(data);
        }
        private bool xunhuanbengdongzuofankuixinhaobei;
        [Description(Name = "循环泵动作反馈信号（备）")]
        public bool XunHuanBengDongZuoFanKuiXinHaoBei { get { return xunhuanbengdongzuofankuixinhaobei; } }
        [Byte(ByteIndex = 24)]
        public void SetXunHuanBengDongZuoFanKuiXinHaoBei(int data)
        {
            xunhuanbengdongzuofankuixinhaobei = GetBoolean(data);
        }
        private bool jishuibengdongzuofankuixinhao;
        [Description(Name = "给水泵动作反馈信号（主）")]
        public bool JiShuiBengDongZuoFanKuiXinHao { get { return jishuibengdongzuofankuixinhao; } }
        [Byte(ByteIndex = 25)]
        public void SetJiShuiBengDongZuoFanKuiXinHao(int data)
        {
            jishuibengdongzuofankuixinhao = GetBoolean(data);
        }
        private bool jishuibengdongzuofankuixinhaobei;
        [Description(Name = "给水泵动作反馈信号（备）")]
        public bool JiShuiBengDongZuoFanKuiXinHaoBei { get { return jishuibengdongzuofankuixinhaobei; } }
        [Byte(ByteIndex = 26)]
        public void SetJiShuiBengDongZuoFanKuiXinHaoBei(int data)
        {
            jishuibengdongzuofankuixinhaobei = GetBoolean(data);
        }
        private bool yinfengjidongzuofankuixinhao;
        [Description(Name = "引风机动作反馈信号")]
        public bool YinFengJiDongZuoFanKuiXinHao { get { return yinfengjidongzuofankuixinhao; } }
        [Byte(ByteIndex = 27)]
        public void SetYinFengJiDongZuoFanKuiXinHao(int data)
        {
            yinfengjidongzuofankuixinhao = GetBoolean(data);
        }
        private bool gufengjidongzuofankuixinhao;
        [Description(Name = "鼓风机动作反馈信号")]
        public bool GuFengJiDongZuoFanKuiXinHao { get { return gufengjidongzuofankuixinhao; } }
        [Byte(ByteIndex = 28)]
        public void SetGuFengJiDongZuoFanKuiXinHao(int data)
        {
            gufengjidongzuofankuixinhao = GetBoolean(data);
        }
        private bool ecigufengjidongzuofankuixinhao;
        [Description(Name = "二次鼓风机动作反馈信号")]
        public bool ECiGuFengJiDongZuoFanKuiXinHao { get { return ecigufengjidongzuofankuixinhao; } }
        [Byte(ByteIndex = 29)]
        public void SetECiGuFengJiDongZuoFanKuiXinHao(int data)
        {
            ecigufengjidongzuofankuixinhao = GetBoolean(data);
        }
        private bool chuzhajidongzuofankuixinhao;
        [Description(Name = "出渣机动作反馈信号")]
        public bool ChuZhaJiDongZuoFanKuiXinHao { get { return chuzhajidongzuofankuixinhao; } }
        [Byte(ByteIndex = 30)]
        public void SetChuZhaJiDongZuoFanKuiXinHao(int data)
        {
            chuzhajidongzuofankuixinhao = GetBoolean(data);
        }
        private bool jishuibianpinqiguzhangxinhao;
        [Description(Name = "给水变频器故障信号")]
        public bool JiShuiBianPinQiGuZhangXinHao { get { return jishuibianpinqiguzhangxinhao; } }
        [Byte(ByteIndex = 31)]
        public void SetJiShuiBianPinQiGuZhangXinHao(int data)
        {
            jishuibianpinqiguzhangxinhao = GetBoolean(data);
        }
        private bool yinfengbianpinqiguzhangxinhao;
        [Description(Name = "引风变频器故障信号")]
        public bool YinFengBianPinQiGuZhangXinHao { get { return yinfengbianpinqiguzhangxinhao; } }
        [Byte(ByteIndex = 32)]
        public void SetYinFengBianPinQiGuZhangXinHao(int data)
        {
            yinfengbianpinqiguzhangxinhao = GetBoolean(data);
        }
        private bool gufengbianpinqiguzhangxinhao;
        [Description(Name = "鼓风变频器故障信号")]
        public bool GuFengBianPinQiGuZhangXinHao { get { return gufengbianpinqiguzhangxinhao; } }
        [Byte(ByteIndex = 33)]
        public void SetGuFengBianPinQiGuZhangXinHao(int data)
        {
            gufengbianpinqiguzhangxinhao = GetBoolean(data);
        }
        private bool lupaibianpinqiguzhangxinhao;
        [Description(Name = "炉排变频器故障信号")]
        public bool LuPaiBianPinQiGuZhangXinHao { get { return lupaibianpinqiguzhangxinhao; } }
        [Byte(ByteIndex = 34)]
        public void SetLuPaiBianPinQiGuZhangXinHao(int data)
        {
            lupaibianpinqiguzhangxinhao = GetBoolean(data);
        }
        private bool yandaodiefafankuixinhao;
        [Description(Name = "烟道蝶阀反馈信号")]
        public bool YanDaoDieFaFanKuiXinHao { get { return yandaodiefafankuixinhao; } }
        [Byte(ByteIndex = 35)]
        public void SetYanDaoDieFaFanKuiXinHao(int data)
        {
            yandaodiefafankuixinhao = GetBoolean(data);
        }
        private bool didianyabaojingxinhao;
        [Description(Name = "低电压报警信号")]
        public bool DiDianYaBaoJingXinHao { get { return didianyabaojingxinhao; } }
        [Byte(ByteIndex = 36)]
        public void SetDiDianYaBaoJingXinHao(int data)
        {
            didianyabaojingxinhao = GetBoolean(data);
        }
        private bool gaodianyabaojingxinhao;
        [Description(Name = "高电压报警信号")]
        public bool GaoDianYaBaoJingXinHao { get { return gaodianyabaojingxinhao; } }
        [Byte(ByteIndex = 37)]
        public void SetGaoDianYaBaoJingXinHao(int data)
        {
            gaodianyabaojingxinhao = GetBoolean(data);
        }
        private bool quexiangbaojingxinhao;
        [Description(Name = "缺相报警信号")]
        public bool QueXiangBaoJingXinHao { get { return quexiangbaojingxinhao; } }
        [Byte(ByteIndex = 38)]
        public void SetQueXiangBaoJingXinHao(int data)
        {
            quexiangbaojingxinhao = GetBoolean(data);
        }
        private bool loudianbaojingxinhao;
        [Description(Name = "漏电报警信号")]
        public bool LouDianBaoJingXinHao { get { return loudianbaojingxinhao; } }
        [Byte(ByteIndex = 39)]
        public void SetLouDianBaoJingXinHao(int data)
        {
            loudianbaojingxinhao = GetBoolean(data);
        }
        private bool queshuidianji2;
        [Description(Name = "缺水电极2")]
        public bool QueShuiDianJi2 { get { return queshuidianji2; } }
        [Byte(ByteIndex = 40)]
        public void SetQueShuiDianJi2(int data)
        {
            queshuidianji2 = GetBoolean(data);
        }
        private bool waibuliansuoxinhao;
        [Description(Name = "外部连锁信号")]
        public bool WaiBuLianSuoXinHao { get { return waibuliansuoxinhao; } }
        [Byte(ByteIndex = 41)]
        public void SetWaiBuLianSuoXinHao(int data)
        {
            waibuliansuoxinhao = GetBoolean(data);
        }
        private bool chaodiyabaohuxinhao;
        [Description(Name = "超低压保护信号")]
        public bool ChaoDiYaBaoHuXinHao { get { return chaodiyabaohuxinhao; } }
        [Byte(ByteIndex = 42)]
        public void SetChaoDiYaBaoHuXinHao(int data)
        {
            chaodiyabaohuxinhao = GetBoolean(data);
        }
    }
}
