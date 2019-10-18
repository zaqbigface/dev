using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventLogViewer
{
    public partial class GridInformetion : Form
    {

        private object[] argumentValues;
        public static string receivevalue;


        public GridInformetion(params object[] argmumentValues)
        {
            this.argumentValues = argumentValues;

            InitializeComponent();
        }

        private void TBInfomation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GridInformetion_Load(object sender, EventArgs e)
        {

            TxBInfomation.Text = receivevalue;
        }

        private void Infomation_Click(object sender, EventArgs e)
        {

        }

        private void TxBInfomation_TextChanged(object sender, EventArgs e)
        {

        }

        public static string ShowGridInformation(DataGridView data, DataGridViewCellEventArgs args)
        {

            GridInformetion g = new GridInformetion();
            receivevalue = String.Format("Information：\r\n\r\n{0}", data[args.ColumnIndex, args.RowIndex].Value);

            g.Show();
            return receivevalue;


        }
    }
}
