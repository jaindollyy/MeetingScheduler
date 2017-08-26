using System;
using MeetingScheduler.Processor.Helper;
using NUnit.Framework;

namespace MeetingScheduler.Tests
{
    public class ConverterTests
    {
        public  DateTime value= Convert.ToDateTime("21/03/2011 09:00:00 AM");
        [TestCase("2011-03-21")]
        public void GetDateFormatTest(string expected)
        {            
            string actual = Converter.GetDateFormat(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("09:00")]
        public void  GetTimeFormatTest(string expected)
        {
            string actual = Converter.GetTimeFormat(value);
            Assert.AreEqual(expected, actual);
        }      
    }
}
