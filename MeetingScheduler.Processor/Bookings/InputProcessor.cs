using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingScheduler.Processor.Entities;

namespace MeetingScheduler.Processor.Bookings
{
    public static class InputProcessor
    {
        public static Schedule[] Process(string[] Inputs)
        {
            string[] officeTimings = Inputs.First().Split(' ');
            Office office = new Office(officeTimings[0], officeTimings[1]);
            BatchProcessor batchProcessor = new BatchProcessor(office);

            Inputs = Inputs.Skip(1).ToArray();
            if (Inputs.Length % 3 == 0)
            {
                DateTime RequestSubmissionTime;
                Employee Employee;
                DateTime StartTime;
                int Duration;
                for (int i = 0; i < Inputs.Length; i += 3)
                {
                    RequestSubmissionTime = DateTime.Parse(Inputs[i + 0]);
                    Employee = new Employee(Inputs[i + 1]);

                    var TimeAndDuration = Inputs[i + 2].Split(' ');
                    StartTime = DateTime.Parse(TimeAndDuration[0] + " " + TimeAndDuration[1]);
                    Duration = int.Parse(TimeAndDuration[2]);

                    Booking booking = new Booking(RequestSubmissionTime, Employee, StartTime, Duration);
                    batchProcessor.AddBooking(booking);
                }
            }

            return batchProcessor.Process();
        }

    }
}
