using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeetingScheduler.Processor.Entities;
using MeetingScheduler.Processor.Helper;

namespace MeetingScheduler.Processor.Bookings
{
   public class BatchProcessor
    {
        private List<Booking> bookings = new List<Booking>();
        public Office Office ;

        public BatchProcessor(Office office)
        {
            Office = office;
        }

        public bool AddBooking(Booking booking)
        {                 
            if (!booking.StartTime.IsBetween(Office.StartTime, this.Office.EndTime) ||
                !booking.EndTime.IsBetween(this.Office.StartTime, this.Office.EndTime))
            {
                return false;
            }

            bookings.Add(booking);
            return true;
        }

       
        public Schedule[] Process()
        {
            // first sort bookings ascendingly to their requested date
            IEnumerable<Booking> orderedBookings = this.bookings.OrderBy(x => x.RequestSubmissionTime);

            Dictionary<DateTime, Schedule> schedules = new Dictionary<DateTime, Schedule>();

            foreach (Booking booking in orderedBookings)
            {
                // add a new schedule for this date if not exist yet
                if (!schedules.ContainsKey(booking.StartTime.Date))
                {
                    schedules[booking.StartTime.Date] = new Schedule(booking.StartTime.Date);
                }
                // add this request to the schedule
                schedules[booking.StartTime.Date].Add(booking);
            }

            // return the schedule in ascending order
            Schedule[] result = schedules.Values.OrderBy(x => x.Date).ToArray<Schedule>();
            return result;
        }      

    }
}
