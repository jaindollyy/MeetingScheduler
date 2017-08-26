using System;
using System.Collections.Generic;

namespace MeetingScheduler.Processor.Bookings
{
   public class ISchedule
    {
        DateTime Date { get; set; }
        List<Booking> Bookings { get;  set; }
    }
}
