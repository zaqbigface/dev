using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpSvn;

namespace MoveFilefForAmazoness
{
    public class Error
    {

        public void NoPathSettingError()
        {
            MessageBox.Show("パスが設定されていません。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }


        public void NoFileMatchError()
        {
            MessageBox.Show("ファイルが一致していません。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
