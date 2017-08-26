
using System;
using MeetingScheduler.Processor.Helper;
using NUnit.Framework;

namespace MeetingScheduler.Tests
{
    public class DateTimeExtensionTests
    {
        [TestCase(false)]
        public void IsBetweenTest1(Boolean expected)
        {
            DateTime value = GetDateTime("2011-03-16 08:17:00");
            TimeSpan start = GetTimeSpan("09:00");
            TimeSpan end = GetTimeSpan("17:30");
           
            Boolean actual = DateTimeExtension.IsBetween(value, start, end);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(true)]
        public void IsBetweenTest2(Boolean expected)
        {
            DateTime value = GetDateTime("2011-03-17 03:17:00 PM");            
            TimeSpan start = GetTimeSpan("09:00");
            TimeSpan end = GetTimeSpan("17:30");

            Boolean actual = DateTimeExtension.IsBetween(value, start, end);
            Assert.AreEqual(expected, actual);
        }

        DateTime GetDateTime(string value)
        {
            return Convert.ToDateTime(value);
        }

        TimeSpan GetTimeSpan(string value)
         {
            return TimeSpan.Parse(value);
         }
    }
}
