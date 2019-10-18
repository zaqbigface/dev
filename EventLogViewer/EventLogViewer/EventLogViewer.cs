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
    public partial class EventLogViewer : Form
    {

        String ServerName;
        String LogName;
        String ResultCount;


        public EventLogViewer()
        {
            InitializeComponent();
        }

        private void CBSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSecurity.Checked == true)
            {
                UnCheckedLogtype("CBSecurity");
            }
        }

        private void CBForwarded_Events_CheckedChanged(object sender, EventArgs e)
        {
            if (CBForwarded_Events.Checked == true)
            {
                UnCheckedLogtype("CBForwarded_Events");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonGet_Click(object sender, EventArgs e)
        {
            if (TBServerName.Text == "" && CBLocalPC.Checked == false)
            {

                var er = new Error();
                er.ErrorNotServerName();
                
            }
            else if(CheckLogtypeChecked() == false)
            {

                var er = new Error();
                er.ErrorNotCheckedLogtype();
                

            }
            else
            {
                int i;

                if (CBLocalPC.Checked)
                {
                    ServerName = ".";
                }
                else
                {
                    ServerName = TBServerName.Text;

                } 

                if (LogName == null | LogName == "" )
                {
                    LogName = GetLogName();
                }

                if (TBResultCount.Text == "")
                {
                    ResultCount = "";
                }
                else if(int.TryParse(TBResultCount.Text, out i) )
                {
                    ResultCount = TBResultCount.Text;
                }

                else
                {
                    var er = new Error();
                    er.ErrorNotint();

                }


                var ge = new GetEventLog();
                List<EventLogEntry> logList = ge.GetEventLogByLogNameAndServer(LogName,ServerName,ResultCount);

                if (logList.Count == 0)
                {
                    LBresult.Text = String.Format("対象：{0}件", logList.Count.ToString());
                    
                }
                else
                {
                    //Gridviewに取得したログエントリーを表示させる。
                    DGEventLog.DataSource = logList;
                    LBresult.Text = String.Format("対象：{0}件", logList.Count.ToString());

                }               

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TBServerName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CBApplication_CheckedChanged(object sender, EventArgs e)
        {
            if (CBApplication.Checked == true)
            {
                UnCheckedLogtype("CBApplication");
            }
 
        }

        private void CBSetup_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSetup.Checked == true)
            {
                UnCheckedLogtype("CBSetup");
            }
            
        }

        private void CBSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSystem.Checked == true)
            {
                UnCheckedLogtype("CBSystem");
            }  
          
        }

        private string GetLogName()
        {

            string name;

            if (CBApplication.Checked)
            {
                name = CBApplication.Text;
            }

            else if (CBSetup.Checked)
            {
                name = CBSetup.Text;
            }
            else if (CBForwarded_Events.Checked)
            {
                name = CBForwarded_Events.Text;     
               
            }
            else if (CBSecurity.Checked)
            {
                name = CBSecurity.Text;
            }
            else if (CBSystem.Checked)
            {
                name = CBSystem.Text;
            }
            else
            {
                name = "";
            }

            return name;
        }

        private void CBLocalPC_CheckedChanged(object sender, EventArgs e)
        {
            ServerName = CBLocalPC.Text;

        }

        private void DGEventLog_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            e.Cancel = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGEventLog_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = new gridviewmethod();

            obj.ShowCellInfometion(sender, e);
        }

        private void UnCheckedLogtype(string CheckedLogtype)
        {
            switch (CheckedLogtype)
            {
                case "CBApplication":
                    LogName = CBApplication.Text;
                    CBSetup.Checked = false;
                    CBForwarded_Events.Checked = false;
                    CBSecurity.Checked = false;
                    CBSystem.Checked = false;
                    break;

                case "CBSetup":
                    LogName = CBSetup.Text;
                    CBApplication.Checked = false;
                    CBForwarded_Events.Checked = false;
                    CBSecurity.Checked = false;
                    CBSystem.Checked = false;
                    break;

                case "CBForwarded_Events":
                    LogName = CBForwarded_Events.Text;
                    CBApplication.Checked = false;
                    CBSetup.Checked = false;
                    CBSecurity.Checked = false;
                    CBSystem.Checked = false;
                    break;

                case "CBSecurity":
                    LogName = CBSecurity.Text;
                    CBApplication.Checked = false;
                    CBSetup.Checked = false;
                    CBForwarded_Events.Checked = false;
                    CBSystem.Checked = false;
                    break;

                case "CBSystem":
                    LogName = CBSystem.Text;
                    CBApplication.Checked = false;
                    CBSetup.Checked = false;
                    CBForwarded_Events.Checked = false;
                    CBSecurity.Checked = false;
                    break;

            }

        }

        private bool CheckLogtypeChecked()
        {
            if(CBApplication.Checked == false && CBSetup.Checked == false && CBForwarded_Events.Checked == false &&
               CBSecurity.Checked == false && CBSystem.Checked == false)
            {

                return false;
            }
            else
            {
                return true;
            }
                        
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void EventLogViewer_Load(object sender, EventArgs e)
        {
            PBprogressBar.Value = 0;
        }


    }
}
