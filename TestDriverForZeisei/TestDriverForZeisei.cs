using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDriverForZeisei
{
     public partial class TestDriverForZeisei : Form
    {
        public static ShiharaiBunpaikinTanka _objST;

        public TestDriverForZeisei()
        {
            InitializeComponent();
        }

        private void TabShiharai_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void TestDriverForZeisei_Load(object sender, EventArgs e)
        {
            ShiharaiBunpaikinTanka objST;
            objST = new ShiharaiBunpaikinTanka();
            _objST = objST;
        }

        private void samplebutton_Click(object sender, EventArgs e)
        {
            Logics objLG = new Logics();
            _objST = objLG.sampleShiharaitanka();

            DataKubun_ST.Text = _objST.dataKubun;
            DataKijunBi_ST.Text = _objST.dataKijunbi;
            RecordSyubetsu_ST.Text = _objST.recordSyubetsu;
            FromCode_ST.Text = _objST.fromCode;
            ToCode_ST.Text = _objST.toCode;
            FromName_ST.Text = _objST.fromName;
            ToName_ST.Text = _objST.toName;
            FundCode_ST.Text = _objST.fundCode;
            SyanaiFund1_ST.Text = _objST.syanaiFund1;
            SyanaiFund1_ST.Text = _objST.syanaiFund2;
            Yobi1_ST.Text = _objST.yobi1;
            FundName_ST.Text = _objST.fundName;
            KijunBi_ST.Text = _objST.kijunbi;
            Yobi2_ST.Text = _objST.yobi2;
            SetteiBi_ST.Text = _objST.setteibi;
            MaruYuu_ST.Text = _objST.maruYuu;
            HitoKuchi_ST.Text = _objST.hitokuchiGanpon;
            Keisan_ST.Text = _objST.keisanKuchisuu;
            GaikaDateShisan_ST.Text = _objST.gaikadateShisanWariai;
            SyuuekiNaikoku_ST.Text = _objST.syuuekiNaikoku;
            KeisanKaishiBi_ST.Text = _objST.yobi3;
            KokyakuShiraiKaishiBi_ST.Text = _objST.kokyakuShiharaiKaishibi;
            Kisuu_ST.Text = _objST.kisuu;
            UnyouNIssuu_ST.Text = _objST.unyouNissuu;
            FutuBupaikin_ST.Text = _objST.bunpaikinTanka;
            Syotokuzei_ST.Text = _objST.syotokuzei;
            Chihouzei_ST.Text = _objST.chihouzei;
            FutuBupaikin_ST.Text = _objST.futuuBunpaikin;
            TokubetsuBunpaikin_ST.Text = _objST.tokubetsuBunpaikin;
            ShiharaiGaikokuzei_ST.Text = _objST.shiharaiGaikokuzeiTanka;
            UnyoRimawari_ST.Text = _objST.unyouRimawari;
            Yobi4_ST.Text = _objST.yobi4;
            Kijyunkagaku_ST.Text = _objST.kijyunKagaku;
            SyuuekiGaikoku_ST.Text = _objST.syuuekiGaikoku;
            Yobi5_ST.Text = _objST.yobi5;

        }
    }
}
