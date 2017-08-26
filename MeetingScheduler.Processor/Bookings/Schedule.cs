using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeetingScheduler.Processor.Bookings;

namespace MeetingScheduler.Processor.Bookings
{
    public class Schedule : ISchedule
    {
        public DateTime Date { get; set; }
        public List<Booking> Bookings { get; set; }

        public Schedule(DateTime date)
        {
            this.Date = date.Date;
            this.Bookings = new List<Booking>();
        }

        public bool Add(Booking newbooking)
        {
            foreach (Booking booking in Bookings)
            {
                if (newbooking.StartTime.TimeOfDay < booking.EndTime.TimeOfDay && newbooking.EndTime.TimeOfDay > booking.StartTime.TimeOfDay)
                {
                    return false;
                }
            }

            this.Bookings.Add(newbooking);
            return true;
        }                  
    }
}
