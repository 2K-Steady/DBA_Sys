using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBA_Sys
{
    class DelayTime
    {
        //public DateTime Delay(int ms)
        //{
        //    DateTime thisMoment = DateTime.Now;
        //    TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
        //    DateTime afterWards = thisMoment.Add(duration);

        //    while (afterWards >= thisMoment)
        //    {
        //        System.Windows.Forms.Application.DoEvents();
        //        thisMoment = DateTime.Now;
        //    }
        //    return DateTime.Now;
        //}

        public DateTime Delay(int hr, int min, int sec) // 시 분 초 
        {
            hr = hr * 1000 * 60 * 60;
            min = min * 1000 * 60;
            sec = sec * 1000;

            int ms = hr + min + sec;
            DateTime thisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime afterWards = thisMoment.Add(duration);

            while (afterWards >= thisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                thisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
    }
}
