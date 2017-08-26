using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingScheduler.Processor.Entities;
using MeetingScheduler.Processor.Helper;

namespace MeetingScheduler.Processor.Bookings
{
    public static class OutputProcessor
    {
        public static string Process(Schedule[] schedules)
        {
            StringBuilder result = new StringBuilder();
            result.Append("Output");
            result.Append(Environment.NewLine);
            foreach (Schedule schedule in schedules)
            {            
                result.AppendFormat("{0}", Converter.GetDateFormat(schedule.Date));
                result.Append(Environment.NewLine);         

                foreach (Booking booking in schedule.Bookings.OrderBy(x => x.StartTime))
                {
                    result.AppendFormat("{0} {1}", Converter.GetTimeFormat(booking.StartTime) ,Converter.GetTimeFormat(booking.EndTime));
                    result.Append(Environment.NewLine);
                    result.AppendFormat("{0}",booking.Employee.ID);
                    result.Append(Environment.NewLine);
                }
            }
            return result.ToString();
        }

    }
}
