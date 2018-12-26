using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;

////using Excel = Microsoft.Office.Interop.Excel;
//코드 상단에 위와 같은 구문을 추가해 주면 좀더 간편하게 코드를 작성할 수 있습니다.


//Excel.Application excelApp = null;
//excelApp = new Excel.Application();
//........
//if (excelApp != null) excelApp.Quit();


//코드의 모든 과정은 일단 Excel.Application 객체를 생성하는 것으로 시작합니다.
//이 과정에서 실제 Excel.exe가 백그라운드에서 실행되어 응용 프로그램과 연결됩니다.
//사용이 끝나면 반드시 Quit()로 종료 시켜 주어야 합니다.

namespace DBA_Sys
{
    class VehicleTest
    {

        public static void FindVehicle(string testDate)
        {
            NewExcel(testDate);
            ModifyClipboard(testDate);
        }

        private static void NewExcel(string testDate)
        {
            Excel.Application application = new Excel.Application();
            Workbook workbook = application.Workbooks.Add();
            Worksheet worksheet = workbook.Worksheets.Add();

            worksheet = workbook.Worksheets.Item[1];
            worksheet.Name = "VehicleList";

            workbook.SaveAs(Filename: @"D:\DBA_SaveData\" + testDate + "\\" + testDate + ".xlsx");
            
            workbook.Close();
            application.Quit();

        }

        private static void ModifyClipboard(string testDate)
        {
            Excel.Application application = new Excel.Application();
            Workbook workbook = application.Workbooks.Open(Filename: @"D:\DBA_SaveData\" + testDate + "\\" + testDate + ".xlsx");
            Worksheet worksheet = workbook.Worksheets.Item["VehicleList"];

            string clipboardText = Clipboard.GetText();

            

            clipboardText = clipboardText.Replace("X", "");
            clipboardText = clipboardText.Replace("Y", "");
            clipboardText = clipboardText.Replace("Z", "");
            clipboardText = clipboardText.Replace("=", "");


            Clipboard.SetText(clipboardText); //그지같은 이 부분좀 흑흑??????
            //MessageBox.Show("여기까지 도달 하는가?");

            Range range = worksheet.Cells[1, 1];

            range.Select();
            worksheet.PasteSpecial(range, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            //========================================================================================================
            //1차 복사 밑 숫자를 제외한 글자 제거 완료// 

            //가져온 차량의 좌표 정보에서 Z값만 +1000 으로 처리하여 이동

            workbook.Save();
            workbook.Close();

            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
        }

        public static void StringChange()
        {
            
            string clipboardText = Clipboard.GetText();

            string searchText = "Z";

            //============================Z앞 잘라내기=================================
            string str = clipboardText.Substring(0, clipboardText.IndexOf(searchText)+2);

            //st2 debugging code
            MessageBox.Show(str);
            //=========================================================================


            //Z를 기준으로 2칸뒤에 있는 나머지 String을 잘라내기=======================
            string str2 = clipboardText.Substring(clipboardText.IndexOf(searchText)+2);

            float num = float.Parse(str2);

            num += 500;

            //str2 debugging code
            MessageBox.Show(num.ToString());

            str2 = num.ToString();
            //==============================String 재결합==============================

            str = str + str2;

            //최종 str debugging code
            MessageBox.Show(str);
            //=========================================================================




        }



    }
}



