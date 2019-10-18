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
    public partial class MoveFIleForAmazoness : Form
    {
        static string _FromFilePath;
        static string _ToFilePath;
        static string _FromFileName;
        static string _ToFileName;
        static DateTime _FromFileTime;
        static DateTime _ToFileTime;


        public MoveFIleForAmazoness()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK){
                FromFilePathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK){
                ToFilePathTextBox.Text = openFileDialog1.FileName;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoveFIleForAmazoness_Load(object sender, EventArgs e)
        {       
            string From = System.Configuration.ConfigurationSettings.AppSettings["FromFilePath"];
            string To = System.Configuration.ConfigurationSettings.AppSettings["ToFilePath"];

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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            if (FromFilePathTextBox.Text == "" | ToFilePathTextBox.Text == "")
            {
                MessageBox.Show("パスが設定されていません。",
                                "エラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (FromFilePathTextBox.Text == "" | ToFilePathTextBox.Text == "")
            {
                MessageBox.Show("パスが設定されていません。",
                                "エラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                return;
            }

            if (_FromFileName != _ToFileName)
            {
                MessageBox.Show("ファイルが一致していません。",
                                "エラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

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
    }
}
