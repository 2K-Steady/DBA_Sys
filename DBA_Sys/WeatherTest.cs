using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Windows.Forms;

namespace DBA_Sys
{
    class WeatherTest
    {
        MainForm mfrm;
        DelayTime delayTime = new DelayTime();
        StatusLog statlog;

        public WeatherTest(MainForm mfrm)
        {
            this.mfrm = mfrm; //MainForm의 컨트롤러를 사용하기 위해서 파라미터를 받아와야함
            StatusLog statlog = new StatusLog(mfrm);
            this.statlog = statlog;
        }

        public void WeatherMain(string testDate)
        {
            CopyFile(testDate);
            delayTime.Delay(0,0,5);
            WeatherErangel(testDate);
            delayTime.Delay(0,0,5);
            WeatherMiramar(testDate);
            delayTime.Delay(0, 0, 5);
            WeatherSanhok(testDate);
            delayTime.Delay(0, 0, 5);
            WeatherVikendi(testDate);
            delayTime.Delay(0, 0, 3);
            
            statlog.statusLog("모든 테스트가 종료되었습니다.");
            
        }

        private void CopyFile(string testDate)
        {
            mfrm.toolStripStatusLabel1.Text = "OverCast Copy..";

            statlog.statusLog("Modify Batch File (Overcast)");

            string sourceFile = @"D:\DBA_SupportProgram\DS_NoBatteEye_Erangel_Overcast.bat";

            string destFile = @"C:\TestBuild\" + testDate + "\\DS_NoBatteEye_Erangel_Overcast.bat";

            //=================================================================================
            System.IO.FileInfo fi = new System.IO.FileInfo(destFile);
            if (fi.Exists)
            {

            }
            else
            {
                FileSystem.CopyFile(sourceFile, destFile); // Erangel
            }
            string sourceFile1 = @"D:\DBA_SupportProgram\DS_NoBatteEye_Miramar_Overcast.bat";

            string destFile1 = @"C:\TestBuild\" + testDate + "\\DS_NoBatteEye_Miramar_Overcast.bat";

            FileSystem.CopyFile(sourceFile1, destFile1); //Miramar

            string sourceFile2 = @"D:\DBA_SupportProgram\DS_NoBatteEye_Sanhok_Overcast.bat";

            string destFile2 = @"C:\TestBuild\" + testDate + "\\DS_NoBatteEye_Sanhok_Overcast.bat";

            FileSystem.CopyFile(sourceFile2, destFile2); //Sanhok

            string sourceFile3 = @"D:\DBA_SupportProgram\DS_NoBatteEye_Vikendi_Night.bat";

            string destFile3 = @"C:\TestBuild\" + testDate + "\\DS_NoBatteEye_Vikendi_Night.bat";

            FileSystem.CopyFile(sourceFile3, destFile3); //Vikendi

            statlog.statusLog("Overcast 파일 복사 완료");
            
        }

        private void WeatherErangel(string testDate)
        {
            mfrm.toolStripStatusLabel1.Text = "Erangel Weather Test";

            statlog.statusLog("에란겔 Weather Overcast 실행");
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = "DS_NoBatteEye_Erangel_Overcast.bat";
            ps.StartInfo.WorkingDirectory = @"C:\TestBuild\" + testDate;
            ps.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps.Start();
            ps.WaitForExit(1000);

            delayTime.Delay(0,0,40);

            statlog.statusLog("Local Client 실행");
            System.Diagnostics.Process ps1 = new System.Diagnostics.Process();
            ps1.StartInfo.FileName = "ClientLocal.bat";
            ps1.StartInfo.WorkingDirectory = @"C:\TestBuild\" + testDate;
            ps1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps1.Start();
            ps1.WaitForExit(1000);

            delayTime.Delay(0,0,70);
            System.Windows.Forms.SendKeys.Send("`");
            delayTime.Delay(0,0,1);
            System.Windows.Forms.SendKeys.Send("Admin UpdateWarmupTime 30");
            delayTime.Delay(0,0,1);
            System.Windows.Forms.SendKeys.Send("{Enter}");
            delayTime.Delay(0,0,60);
            System.Windows.Forms.SendKeys.Send("F");
            delayTime.Delay(0,0,10);
            System.Windows.Forms.SendKeys.Send("^R");
            delayTime.Delay(0,0,3);
            //System.Windows.Forms.SendKeys.Send("`");
            //delayTime.Delay(0,0,2);
            //System.Windows.Forms.SendKeys.Send("Admin VisibleInvulnerablilityEffect 0");
            //delayTime.Delay(0,0,5);
            //System.Windows.Forms.SendKeys.Send("{Enter}");
            //delayTime.Delay(0,0,4);
            //System.Windows.Forms.SendKeys.Send("^Q");
            //delayTime.Delay(0,0,2);
            //Keyboard.HoldKey(0x20, 2000);

            delayTime.Delay(0, 10, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\E_weatherTest_1.png");
            delayTime.Delay(0, 10, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\E_weatherTest_2.png");
            delayTime.Delay(0, 10, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\E_weatherTest_3.png");
            delayTime.Delay(0, 5, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\E_weatherTest_End.png");

            statlog.statusLog("35분 경과했습니다. 테스트 종료 시퀀스 진입");
            KillProcess();
            
        }

        private void WeatherMiramar(string testDate)
        {
            mfrm.toolStripStatusLabel1.Text = "Miramar Weather Test";

            statlog.statusLog("미라마 Weather Overcast 실행");
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = "DS_NoBatteEye_Miramar_Overcast.bat";
            ps.StartInfo.WorkingDirectory = @"C:\TestBuild\" + testDate;
            ps.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps.Start();
            ps.WaitForExit(1000);

            delayTime.Delay(0, 0, 40);

            statlog.statusLog("Local Client 실행");
            System.Diagnostics.Process ps1 = new System.Diagnostics.Process();
            ps1.StartInfo.FileName = "ClientLocal.bat";
            ps1.StartInfo.WorkingDirectory = @"C:\TestBuild\" + testDate;
            ps1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps1.Start();
            ps1.WaitForExit(1000);

            delayTime.Delay(0, 0, 70);
            System.Windows.Forms.SendKeys.Send("`");
            delayTime.Delay(0, 0, 1);
            System.Windows.Forms.SendKeys.Send("Admin UpdateWarmupTime 30");
            delayTime.Delay(0, 0, 1);
            System.Windows.Forms.SendKeys.Send("{Enter}");
            delayTime.Delay(0, 0, 60);
            System.Windows.Forms.SendKeys.Send("F");
            delayTime.Delay(0, 0, 10);
            System.Windows.Forms.SendKeys.Send("^R");
            delayTime.Delay(0, 0, 3);
            //System.Windows.Forms.SendKeys.Send("`");
            //delayTime.Delay(0, 0, 2);
            //System.Windows.Forms.SendKeys.Send("Admin VisibleInvulnerablilityEffect 0");
            //delayTime.Delay(0, 0, 2);
            //System.Windows.Forms.SendKeys.Send("{Enter}");
            //delayTime.Delay(0, 0, 4);
            //System.Windows.Forms.SendKeys.Send("^Q");
            //delayTime.Delay(0, 0, 2);
            //Keyboard.HoldKey(0x20, 2000);

            delayTime.Delay(0, 10, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\M_weatherTest_1.png");
            delayTime.Delay(0, 10, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\M_weatherTest_2.png");
            delayTime.Delay(0, 10, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\M_weatherTest_3.png");
            delayTime.Delay(0, 5, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\M_weatherTest_End.png");

            statlog.statusLog("35분 경과했습니다. 미라마 테스트 종료");
            KillProcess();
        }

        private void WeatherSanhok(string testDate)
        {
            mfrm.toolStripStatusLabel1.Text = "Sanhok Weather Test";

            statlog.statusLog("사녹 Weather Overcast 실행");
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = "DS_NoBatteEye_Sanhok_Overcast.bat";
            ps.StartInfo.WorkingDirectory = @"C:\TestBuild\" + testDate;
            ps.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps.Start();
            ps.WaitForExit(1000);

            delayTime.Delay(0, 0, 40);

            statlog.statusLog("Local Client 실행");
            System.Diagnostics.Process ps1 = new System.Diagnostics.Process();
            ps1.StartInfo.FileName = "ClientLocal.bat";
            ps1.StartInfo.WorkingDirectory = @"C:\TestBuild\" + testDate;
            ps1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps1.Start();
            ps1.WaitForExit(1000);

            delayTime.Delay(0, 0, 70);
            System.Windows.Forms.SendKeys.Send("`");
            delayTime.Delay(0, 0, 1);
            System.Windows.Forms.SendKeys.Send("Admin UpdateWarmupTime 30");
            delayTime.Delay(0, 0, 1);
            System.Windows.Forms.SendKeys.Send("{Enter}");
            delayTime.Delay(0, 0, 60);
            System.Windows.Forms.SendKeys.Send("F");
            delayTime.Delay(0, 0, 10);
            System.Windows.Forms.SendKeys.Send("^R");
            delayTime.Delay(0, 0, 3);
            //System.Windows.Forms.SendKeys.Send("`");
            //delayTime.Delay(0, 0, 2);
            //System.Windows.Forms.SendKeys.Send("Admin VisibleInvulnerablilityEffect 0");
            //delayTime.Delay(0, 0, 2);
            //System.Windows.Forms.SendKeys.Send("{Enter}");
            //delayTime.Delay(0, 0, 4);
            //System.Windows.Forms.SendKeys.Send("^Q");
            //delayTime.Delay(0, 0, 2);
            //Keyboard.HoldKey(0x20, 2000);

            delayTime.Delay(0, 10, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\S_weatherTest_1.png");
            delayTime.Delay(0, 10, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\S_weatherTest_2.png");
            delayTime.Delay(0, 5, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\S_weatherTest_3.png");
            //delayTime.Delay(0, 5, 0);
            //ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\M_weatherTest_End.png");

            statlog.statusLog("25분 경과했습니다. 사녹 테스트 종료");
            KillProcess();
        }

        private void WeatherVikendi(string testDate)
        {
            mfrm.toolStripStatusLabel1.Text = "Vikendi Weather Test";

            statlog.statusLog("비켄디 Weather Night 실행");
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = "DS_NoBatteEye_Vikendi_Night.bat";
            ps.StartInfo.WorkingDirectory = @"C:\TestBuild\" + testDate;
            ps.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps.Start();
            ps.WaitForExit(1000);

            delayTime.Delay(0, 0, 40);

            statlog.statusLog("Local Client 실행");
            System.Diagnostics.Process ps1 = new System.Diagnostics.Process();
            ps1.StartInfo.FileName = "ClientLocal.bat";
            ps1.StartInfo.WorkingDirectory = @"C:\TestBuild\" + testDate;
            ps1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps1.Start();
            ps1.WaitForExit(1000);

            delayTime.Delay(0, 0, 70);
            System.Windows.Forms.SendKeys.Send("`");
            delayTime.Delay(0, 0, 1);
            System.Windows.Forms.SendKeys.Send("Admin UpdateWarmupTime 30");
            delayTime.Delay(0, 0, 1);
            System.Windows.Forms.SendKeys.Send("{Enter}");
            delayTime.Delay(0, 0, 60);
            System.Windows.Forms.SendKeys.Send("F");
            delayTime.Delay(0, 0, 10);
            System.Windows.Forms.SendKeys.Send("^R");
            delayTime.Delay(0, 0, 3);
            //System.Windows.Forms.SendKeys.Send("`");
            //delayTime.Delay(0, 0, 2);
            //System.Windows.Forms.SendKeys.Send("Admin VisibleInvulnerablilityEffect 0");
            //delayTime.Delay(0, 0, 2);
            //System.Windows.Forms.SendKeys.Send("{Enter}");
            //delayTime.Delay(0, 0, 4);
            //System.Windows.Forms.SendKeys.Send("^Q");
            //delayTime.Delay(0, 0, 2);
            //Keyboard.HoldKey(0x20, 2000);

            delayTime.Delay(0, 10, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\V_weatherTest_1.png");
            delayTime.Delay(0, 10, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\V_weatherTest_2.png");
            delayTime.Delay(0, 5, 0);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\V_weatherTest_3.png");
            //delayTime.Delay(0, 5, 0);
            //ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate + "\\M_weatherTest_End.png");

            statlog.statusLog("25분 경과했습니다. 비켄디 테스트 종료");
            KillProcess();
        }

        private void KillProcess()
        {
            mfrm.toolStripStatusLabel1.Text = "Killing Process";

            Process[] processList = Process.GetProcessesByName("TslGame");
            foreach (Process p in processList)
            {
                p.Kill();
            }
            statlog.statusLog("Exit Client");

            Process[] processList1 = Process.GetProcessesByName("TslGameServer");
            foreach (Process p in processList1)
            {
                p.Kill();
            }
            statlog.statusLog("Exit Server");
        }

        //private void statusLog(string substance)
        //{
        //    ListViewItem item;
        //    item = new ListViewItem(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        //    item.SubItems.Add(substance);
        //    mfrm.logView.Items.Add(item);
        //}

    }
}
