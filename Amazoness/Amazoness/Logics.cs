using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpSvn;
using System.Collections.ObjectModel;

namespace MoveFilefForAmazoness
{
    public class Logics
    {
        public string showFileDialogToFileName(OpenFileDialog od)
        {
            string result;
            result = "";

            DialogResult dr = od.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                result = od.FileName;
                return result;
            }
            else
            {
                return result;
            }

        }

        public string showFolderDialogToFileName(FolderBrowserDialog fbd)
        {
            string result;
            result = "";

            fbd.SelectedPath = @"C:\";
            DialogResult dr = fbd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                result = fbd.SelectedPath;
                return result;
            }
            else
            {
                return result;
            }

        }

        public string getAppConfigValue(string key)
        {
            string result;

            result = System.Configuration.ConfigurationManager.AppSettings[key];

            return result;
        }

        public List<SvnInfoEventArgs> getSVNInfo()
        {
            SvnClient client = new SvnClient();
            List<SvnInfoEventArgs> svninfo = new List<SvnInfoEventArgs>();

            string repo;
            string path;
            repo = getAppConfigValue("SVNServerPath");
            path = getAppConfigValue("SVNTargetPath");

            if (repo == "" | path == "")
            {
                Error er = new Error();
                er.NoPathSettingError();

            }
            //レポジトリの設定
            SvnUriTarget repos = new SvnUriTarget(new Uri(repo));

            //ターゲットのフォルダの設定
            SvnPathTarget local = new SvnPathTarget(path);

            client.Authentication.Clear();
            client.Authentication.DefaultCredentials = new System.Net.NetworkCredential("zaqbigface", "Z@qbigface691910");
            //client.Authentication.SslServerTrustHandlers += delegate (object sender, SvnSslServerTrustEventArgs e) {
            //    e.AcceptedFailures = e.Failures;
            //    e.Save = true;//Save acceptance to authentication store
            //};

            SvnInfoEventArgs serverInfo;
            SvnInfoEventArgs clientInfo;

            //;が付いたパスだとエラーになるとの情報だが無くてもエラーになる、、
            client.GetInfo(repos, out serverInfo);
            client.GetInfo(local, out clientInfo);

            svninfo.Add(serverInfo);
            svninfo.Add(clientInfo);

            return svninfo;

        }

        }
}
