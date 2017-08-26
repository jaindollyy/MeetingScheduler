using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler.Processor.Helper
{
    public static class Converter
    {        
   
        public static string GetDateFormat(DateTime value)
        {
            return value.ToString("yyyy-MM-dd");
        }

        public static string GetTimeFormat(DateTime value)
        {
            return value.ToString("HH:mm");
        }

    }

}
