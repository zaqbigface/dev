using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventLogViewer
{
    class gridviewmethod
    {
        public void ShowCellInfometion(object sender, DataGridViewCellEventArgs args)
        {
            DataGridView g = sender as DataGridView;

             if (g != null)
            {
                GridInformetion.ShowGridInformation(g, args);
            }
        }

    }
}
