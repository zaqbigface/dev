using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpSvn;

namespace MoveFilefForAmazoness
{
    public partial class Amazoness : Form
    {
        static string _FromFilePath;
        static string _ToFilePath;
        static string _SVNTargetPath;
        static string _FromFileName;
        static string _ToFileName;
        static DateTime _FromFileTime;
        static DateTime _ToFileTime;

        static Logics _Logic;
        static Error _Error;

        public Amazoness()
        {
            InitializeComponent();

            //LogicクラスとErrorクラスをあらかじめインスタンス化しておく
            _Logic = new Logics();
            _Error = new Error();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FileDiffLastWriteTimeButton_Click(object sender, EventArgs e)
        {
            FromFilePathTextBox.Text = _Logic.showFileDialogToFileName(OpenFileDialog1);
        }

        private void ToFileLoadButton_Click(object sender, EventArgs e)
        {

            ToFileLoadButton.Text = _Logic.showFileDialogToFileName(OpenFileDialog1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoveFIleForAmazoness_Load(object sender, EventArgs e)
        {
            string From = _Logic.getAppConfigValue("FromFilePath");
            string To = _Logic.getAppConfigValue("ToFilePath");
            string SVN = _Logic.getAppConfigValue("SVNTargetPath");

            if (From != "")
            {
                _FromFilePath = From;
                FromFilePathTextBox.Text = _FromFilePath;
            }

            if(To != "")
            {
                _ToFilePath = To;
                ToFilePathTextBox.Text = _ToFilePath;
            }

            if (SVN != "")
            {
                _SVNTargetPath = SVN;
                SVNTargetPathTextBox.Text = _SVNTargetPath;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileDiffLastWriteTimeButton_Click_1(object sender, EventArgs e)
        {
            
            if (FromFilePathTextBox.Text == "" | ToFilePathTextBox.Text == "")
            {
                _Error.NoPathSettingError();
                return;
            }

            
            //フルパス
            _FromFilePath = FromFilePathTextBox.Text;
            _ToFilePath = ToFilePathTextBox.Text;

            //ファイル名
            _FromFileName = System.IO.Path.GetFileName(_FromFilePath);
            _ToFileName = System.IO.Path.GetFileName(_ToFilePath);

            //ファイルの更新日付
            _FromFileTime = System.IO.File.GetLastWriteTime(_FromFilePath);
            _ToFileTime = System.IO.File.GetLastWriteTime(_ToFilePath);

            FromFileName.Visible = true;
            FromFileName.Text = _FromFileName;
                        
            ToFileName.Visible = true;
            ToFileName.Text = _ToFileName;
            
            FromFileTime.Visible = true;
            FromFileTime.Text = _FromFileTime.ToString() ;

            ToFileTime.Visible = true;
            ToFileTime.Text = _ToFileTime.ToString();

        }

        private void FileMoveButton_Click(object sender, EventArgs e)
        {
            if (FromFilePathTextBox.Text == "" | ToFilePathTextBox.Text == "")
            {
                _Error.NoPathSettingError();
                return;
            }

            if (_FromFileName != _ToFileName)
            {
                _Error.NoFileMatchError();
                return;

            }
            else
            {
                if (_ToFileTime < _FromFileTime)
                {
                    DialogResult result = MessageBox.Show("移動先の方が更新日が新しくなっています移動しますか？",
                                    "ファイル移動しますか？",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button2);

                    switch (result)
                    {
                        case DialogResult.OK:

                            if(BackupOK.Checked == true)
                            {
                                System.IO.File.Move(_ToFilePath, _ToFilePath + DateTime.Now.ToString("yyyyMMddhhmmss"));
                                System.IO.File.Copy(_FromFilePath, _ToFilePath);
                                MessageBox.Show("ファイルのコピーが完了しました。",
                                                "コピー完了",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            
                            }
                            else
                            {
                                System.IO.File.Copy(_FromFilePath, _ToFilePath, true);
                                MessageBox.Show("ファイルのコピーが完了しました。",
                                                "コピー完了",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }

                            break;

                        case DialogResult.No:
                            break;

                        case DialogResult.Cancel:
                            break;

                        default:
                            break;

                    }

                }
                else
                {
                    if (BackupOK.Checked == true)
                    {
                        System.IO.File.Move(_ToFilePath, _ToFilePath + DateTime.Now.ToString("yyyyMMddhhmmss"));
                        System.IO.File.Copy(_FromFilePath, _ToFilePath);
                        MessageBox.Show("ファイルのコピーが完了しました。",
                                        "コピー完了",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    }
                    else
                    {
                        System.IO.File.Copy(_FromFilePath, _ToFilePath, true);
                        MessageBox.Show("ファイルのコピーが完了しました。",
                                        "コピー完了",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }

                }

            }

        }

        private void SVNTargetPathLoadButton_Click_1(object sender, EventArgs e)
        {

            SVNTargetPathTextBox.Text = _Logic.showFolderDialogToFileName(folderBrowserDialog1);
        }

        private void GetSVNInfoButton_Click(object sender, EventArgs e)
        {
            List<SvnInfoEventArgs> svninfo = new List<SvnInfoEventArgs>();
            svninfo = _Logic.getSVNInfo();

            //本来はリストごと渡してGridViewに表示させたい
            SvnInfoEventArgs test = svninfo[0];

            SVNInfoShow infoShow = new SVNInfoShow(test);
            infoShow.Show();

        }
    }
}
