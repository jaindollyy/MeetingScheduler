using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler.Processor.Helper
{
    public static class DateTimeExtension
    {        
        public static bool IsBetween(this DateTime value, TimeSpan start, TimeSpan end)
        {
            return start <= value.TimeOfDay && end >= value.TimeOfDay;
        }      

    }

}
