using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBA_Sys
{
    class WeatherChange
    {
        private static TextBox testDate;


        public void SetText(object box, string message) // Mainform의 TestDate String 복사용
        {
            testDate = box as TextBox;

            if (testDate != null)
            {
                testDate.Text = message;
            }
        }
    }
}
