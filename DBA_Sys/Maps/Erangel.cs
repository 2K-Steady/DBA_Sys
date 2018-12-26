using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace DBA_Sys
{
    class Erangel
    {
       private static TextBox testDate;


        public void SetText(object box, string message) // Mainform의 TestDate String 복사용
        {
            testDate = box as TextBox;

            if(testDate != null)
            {
                testDate.Text = message;
            }
        }

        public static void ErangelTest()
        {
            
            Erangel.StartServer();
            System.Threading.Thread.Sleep(30000);
            Erangel.StartClient();
            System.Threading.Thread.Sleep(50000);
            Erangel.SetWaitTime();
            System.Threading.Thread.Sleep(50000);
            Erangel.CheckAirplane();
            Erangel.CheckDefaultControl();
        }

        private static void StartServer() // Erangel DS서버 실행
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = "DedicatedServer_NoBattleEye_Airborne_JoinAny.bat";
            ps.StartInfo.WorkingDirectory = @"C:\TestBuild\" + testDate.Text;
            ps.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps.Start();
            ps.WaitForExit(1000);
        }

        private static void StartClient() // ClientLocal 실행 
        {
            System.Diagnostics.Process ps = new System.Diagnostics.Process();
            ps.StartInfo.FileName = "ClientLocal.bat";
            ps.StartInfo.WorkingDirectory = @"C:\TestBuild\" + testDate.Text;
            ps.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            ps.Start();
            ps.WaitForExit(1000);
        }

        private static void SetWaitTime() // 비행기 탑승 대기 시간 설정 및 시작 섬 확인
        {
            System.Threading.Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.Send("`");
            System.Threading.Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.Send("Admin UpdateWarmupTime 30 ");
            System.Threading.Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.Send("{Enter}");
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate.Text + "\\StartIlandEnter.png");
        }

        private static void CheckAirplane() // 대기 시간 이후 비행기 탑승 확인
        {
            System.Threading.Thread.Sleep(1000);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate.Text + "\\StartIland_Airplane.png");
            System.Threading.Thread.Sleep(60000);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate.Text + "\\AirPlane_Parachute1.png");
            System.Threading.Thread.Sleep(20000);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate.Text + "\\AirPlane_Parachute2.png");
            System.Threading.Thread.Sleep(10000);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate.Text + "\\AirPlane_Parachute3.png");
            System.Threading.Thread.Sleep(15000);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + testDate.Text + "\\AirPlane_Parachute4.png");
            System.Threading.Thread.Sleep(1000);
        }

        private static void CheckDefaultControl()
        {
            System.Windows.Forms.SendKeys.Send("`");
            System.Threading.Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.Send("Admin MovePlayer 361920.41 410290.25 3792.49 0 354.09 210.37 0.00");
            System.Threading.Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.Send("{Enter}");
            System.Threading.Thread.Sleep(1000);
            Keyboard.HoldKey(0x57, 3000); //W키 입력 3초간 
            Keyboard.HoldKey(0x53, 3000); //S키 입력 3초간
            Keyboard.HoldKey(0x41, 3000); //A키 입력 3초간
            Keyboard.HoldKey(0x44, 3000); //D키 입력 3초간

            Keyboard.WithKey(0x57, 0xA0, 3000); // L Shift + W키 3초간 입력

        }
        
    }
}
