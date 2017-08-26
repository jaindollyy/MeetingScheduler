using System;
using MeetingScheduler.Processor.Entities;

namespace MeetingScheduler.Processor.Bookings
{
   public class IBooking
   {
         DateTime RequestSubmissionTime { get;  set; }       
         Employee Employee { get;  set; }       
         DateTime StartTime { get;  set; }       
         DateTime EndTime { get;  set; }
    }
}
