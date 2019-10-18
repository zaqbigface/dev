using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventLogViewer
{
    class Error
    {
        public void ErrorNotServerName()
        {
            MessageBox.Show("Server名を入力してください。",
                            "サーバー名未入力エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public void ErrorNotint()
        {
            MessageBox.Show("表示件数には数字のみを入れてください。",
                            "表示件数入力エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public void ErrorNotCheckedLogtype()
        {
            MessageBox.Show("Logtypeが選択されていません。",
                            "Logtype未入力エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
