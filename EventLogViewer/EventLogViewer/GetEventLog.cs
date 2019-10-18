using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace EventLogViewer
{
    class GetEventLog
    {
       public List<EventLogEntry> GetEventLogByLogNameAndServer(String LogName, String ServerName,String ResultCount){
        

           EventLog log = new EventLog(LogName,ServerName);          
           List<EventLogEntry> loglist = new List<EventLogEntry>();

           //ログエントリーがあったらリストに追加していく、無ければ空のリストを返す。
           try
           {
               foreach (EventLogEntry entry in log.Entries)
               {
                   loglist.Add(entry);
               }

               log.Close();
           }
           catch (Exception ex)
           {
               log.Close();
               return loglist;
           }

           //降順にする
           //ソートしても、一度変数に入れないと反映されないみたいなので、一時変数に格納。
           var tmplist = loglist.OrderByDescending(rec => rec.Index);
           List<EventLogEntry> sortlist = tmplist.ToList();


           //表示件数が入力されてない場合はそのまま全件返す。
           if (ResultCount == "")
           {
               return sortlist;
           }
           //表示件数が入力されている場合は表示件数分取得して返す。
           else
           {
               int number = int.Parse(ResultCount);
               int i = 0;
               List<EventLogEntry> list = new List<EventLogEntry>();

               while (i != number)
               {
                   //listからひとつずつ取り出すのに無理やりこの書き方に、、
                   list.Add(sortlist[i]);

                   i++;
               }

               return list;

           }

       }


    }
}
