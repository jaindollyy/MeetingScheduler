using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler.Processor.Entities
{
   public class Office
    {
        public readonly TimeSpan StartTime;
        public readonly TimeSpan EndTime;

        public Office(string start, string end)
        {
            int StartHour = int.Parse(start.Substring(0, 2));
            int StartMinute = int.Parse(start.Substring(2));
            int EndHour = int.Parse(end.Substring(0, 2));
            int EndMinute = int.Parse(end.Substring(2));
         
            this.StartTime = new TimeSpan(StartHour, StartMinute, 0);
            this.EndTime = new TimeSpan(EndHour, EndMinute, 0);
        }
               
    }
}
