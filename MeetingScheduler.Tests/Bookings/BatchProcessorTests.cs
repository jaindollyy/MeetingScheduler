using System;
using MeetingScheduler.Processor.Entities;
using MeetingScheduler.Processor.Bookings;
using MeetingScheduler.Processor.Helper;

using System.Collections.Generic;
using NUnit.Framework;
using System.Text;
using System.Linq;

namespace MeetingScheduler.Tests
{
    public class BatchProcessorTest
    {
        [TestCase(0, 0, "2011-03-21 09:00 11:00 EMP002")]
        [TestCase(1, 0, "2011-03-22 14:00 16:00 EMP003")]
        [TestCase(1, 1, "2011-03-22 16:00 17:00 EMP004")]

        public void TestMethodProcess(int scheduleIndex, int bookingIndex, string expected)
        {
            Schedule[] actual;

            String[] Inputs = new string[]{ "0900 1730"
                                           ,"2011-03-17 10:17:06"
                                           ,"EMP001"
                                           ,"2011-03-21 09:00 2"
                                           ,"2011-03-16 12:34:56"
                                           ,"EMP002"
                                           ,"2011-03-21 09:00 2"
                                           ,"2011-03-16 09:28:23"
                                           ,"EMP003"
                                           ,"2011-03-22 14:00 2"
                                           ,"2011-03-17 11:23:45"
                                           ,"EMP004"
                                           ,"2011-03-22 16:00 1"
                                           ,"2011-03-15 17:29:12"
                                           ,"EMP005"
                                           ,"2011-03-21 16:00 3"};

            actual= InputProcessor.Process(Inputs);
             
            Schedule Schedule = actual[scheduleIndex];
            Booking Booking = Schedule.Bookings[bookingIndex];

            Assert.That(Converter.GetDateFormat(Schedule.Date) + " " + Converter.GetTimeFormat(Booking.StartTime) +
                " " + Converter.GetTimeFormat(Booking.EndTime) + " " + Booking.Employee.ID
                , Is.EqualTo(expected));
        }

    }
}
