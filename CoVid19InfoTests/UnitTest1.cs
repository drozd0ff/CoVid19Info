using System;
using CoVid19Info.Services;
using NUnit.Framework;

namespace CoVid19InfoTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetTodayTimeStampTest()
        {
            var result = DateTimeWithTimestamp.GetTodayTimestamp();

            Assert.AreEqual(DateTimeOffset.Now.Date, result);
        }
        
        [Test]
        public void IsTimestampTodayTest()
        {
            var result = 1591993980565;

            Assert.AreEqual(DateTimeOffset.Now.Date, result);
        }
    }
}