using System;
using System.Linq;
using MeetingScheduler.Processor.Entities;

namespace MeetingScheduler.Processor.Bookings
{
    public class Booking : IBooking
    {
        public DateTime RequestSubmissionTime { get; set; }
        public Employee Employee { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        public Booking(DateTime requestSubmissionTime, Employee employee, DateTime startTime, int duration)
        {
            this.RequestSubmissionTime = requestSubmissionTime;
            this.Employee = employee;
            this.StartTime = startTime;
            this.EndTime = startTime.AddHours(duration);
        }    
        
    }
}
