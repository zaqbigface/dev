using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriverForZeisei
{
    public class Logics
    {
        public ShiharaiBunpaikinTanka sampleShiharaitanka()
        {
            ShiharaiBunpaikinTanka objST;
            objST = new ShiharaiBunpaikinTanka();

            objST.dataKubun = "3";
            objST.dataKijunbi = "20191001";
            objST.recordSyubetsu = "0201";
            objST.fromCode = "90012";
            objST.toCode = "11060";
            objST.fromName = "明治安田アセットマネジメント株式会社 ";
            objST.toName = "カブドットコム証券株式会社";
            objST.fundCode = "200266";
            objST.syanaiFund1 = "3112300006";
            objST.syanaiFund2 = "";
            objST.yobi1 = "";
            objST.fundName = "明治安田米国リート・インカム・プレミアム・ファンド（毎月決算";
            objST.kijunbi = "20191001";
            objST.yobi2 = "";
            objST.setteibi = "20140530";
            objST.maruYuu = "1";
            objST.hitokuchiGanpon = "1.000";
            objST.keisanKuchisuu = "10000";
            objST.gaikadateShisanWariai = "0";
            objST.syuuekiNaikoku = "0";
            objST.keisankaishibi = "20190903";
            objST.yobi3 = "20191002";
            objST.kokyakuShiharaiKaishibi = "20191007";
            objST.kisuu = "64";
            objST.unyouNissuu = "29";
            objST.bunpaikinTanka = "70.0000000";
            objST.syotokuzei = "0.00000";
            objST.chihouzei = "0.00000";
            objST.futuuBunpaikin = "0.0000000";
            objST.tokubetsuBunpaikin = "0.0000000";
            objST.shiharaiGaikokuzeiTanka = "0.0000000";
            objST.unyouRimawari = "0.0000000";
            objST.yobi4 = "18027519312";
            objST.kijyunKagaku = "0";
            objST.syuuekiGaikoku = "0.0000000";
            objST.yobi5 = "";

            return objST;
        }

        public List<string> classToStringList(ShiharaiBunpaikinTanka st)
        {
            List<string> sl = new List<string>();

            var type = typeof(ShiharaiBunpaikinTanka);
            foreach  (var field in type.GetFields())
            {
                var value = field.GetValue(type);
                sl.Add(value.ToString());
            }

            return sl;

        }
    }
}
