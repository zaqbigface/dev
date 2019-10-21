using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveFilefForAmazoness
{
    public partial class SVNInfoShow : Form
    {

        private object[] args;
        static DataGridView dv;




        public SVNInfoShow(params object[] args)
        {

            InitializeComponent();

            this.args = args;
            dv = new DataGridView();
        }

        private void SVNInfoView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SVNInfoShow_Load(object sender, EventArgs e)
        {
            dv.DataSource = args[1];
            
        }
    }
}
