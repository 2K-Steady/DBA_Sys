using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBA_Sys
{
    class RunProcess
    {
        public static void RunKalmuri()
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = "Kalmuri.exe";
            ps.StartInfo.WorkingDirectory = @"D:\DBA_SupportProgram";
            ps.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps.Start();
            ps.WaitForExit(1000);
        }

        public static void RunBandicam()
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            //ps.StartInfo.FileName = "Bandicam.lnk";
            ps.StartInfo.FileName = "bdcam_nonadmin";
            ps.StartInfo.WorkingDirectory = @"D:\DBA_SupportProgram";
            ps.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps.Start();
            ps.WaitForExit(1000);
        }

        public static void RunApVkp()
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = "ApVkp.lnk";
            ps.StartInfo.WorkingDirectory = @"D:\DBA_SupportProgram";
            ps.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps.Start();
            ps.WaitForExit(1000);
        }
    }
}
