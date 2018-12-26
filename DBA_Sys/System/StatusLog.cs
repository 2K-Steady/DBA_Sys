using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBA_Sys
{
    class StatusLog
    {
        MainForm mfrm;

        public StatusLog(MainForm mfrm)
        {
            this.mfrm = mfrm;
        }


        public void statusLog(string substance)
        {
            ListViewItem item;
            item = new ListViewItem(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(substance);
            mfrm.logView.Items.Add(item);
        }
    }
}
