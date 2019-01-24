using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace DBA_Sys
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        //==================입력된 파라미터의 이름으로 새폴더 생성 함수================
        private void CreateFolder(string strDataFolder)
        {
            if (!System.IO.Directory.Exists(@"D:\DBA_SaveData\" + strDataFolder))
            {
                System.IO.Directory.CreateDirectory(@"D:\DBA_SaveData\" + strDataFolder);
            }

            //if (!System.IO.Directory.Exists(folderName))
            //{
            //    System.IO.Directory.CreateDirectory(folderName);
            //}
        }
        //=============================================================================

        public void timeLog(string substance)
        {
            ListViewItem item;
            item = new ListViewItem(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(substance);
            logView.Items.Add(item);
            
        }

        private void TestBuildDown_Button_Click(object sender, EventArgs e)
        {
            
            if (TestDate != null && !string.IsNullOrWhiteSpace(TestDate.Text))
            {
                CopyTestBuild.CopyBuild(TestDate.Text);
            }
            else
            {
                MessageBox.Show("테스트 날짜를 입력해주세요");

                return;
            }
        }

        private void TestButton_1_Click(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = "이건 왜 안바뀜?";

            //if (TestDate != null && !string.IsNullOrWhiteSpace(TestDate.Text))
            //{
            //    FolderBrowserDialog dialog = new FolderBrowserDialog();
            //    dialog.ShowDialog();
            //    string selected = dialog.SelectedPath;
            //    CreateFolder(selected + @"\\" + TestDate.Text);
            //}
            //else
            //{
            //    MessageBox.Show("테스트 날짜를 입력해주세요");

            //    return;
            //}
            if (TestDate != null && !string.IsNullOrWhiteSpace(TestDate.Text))
            {
                FirewallTest.Inbound("TslDBA", TestDate.Text);
            }
            else
            {
                MessageBox.Show("테스트 날짜를 입력해주세요");
                return;
            }
            
        
        }

        private void SaveScreenShotButton_Click(object sender, EventArgs e) 
        {
            CreateFolder(TestDate.Text);
            ScreenShot.Copy(@"D:\DBA_SaveData\" + TestDate.Text + "\\test.png");
        }

        private void ProgramOnButton_Click(object sender, EventArgs e)
        {
            //RunProcess.RunKalmuri(); 자체 함수로 스크린샷 촬영 및 저장하도록 변경
            RunProcess.RunBandicam();
            RunProcess.RunApVkp();
        }

        private void Test_Start_Button_Click(object sender, EventArgs e)
        {
            CreateFolder(TestDate.Text);

            Erangel erangel = new Erangel();
            erangel.SetText(TestDate, TestDate.Text);
            erangel = null;

            Erangel.ErangelTest();

        }

        private void timerTestButton_Click(object sender, EventArgs e)
        {
            
        }

        private void VehicleTestButton_Click(object sender, EventArgs e)
        {
            CreateFolder(TestDate.Text);
            VehicleTest.FindVehicle(TestDate.Text); // 빌드 넘버로 파일 생성을 위해 값을 복사
        }

        private void WeatherButton_Click(object sender, EventArgs e)
        {
            CreateFolder(TestDate.Text);
            WeatherTest weatherTest = new WeatherTest(this);
            weatherTest.WeatherMain(TestDate.Text);


            weatherTest = null;
        }
    }

}