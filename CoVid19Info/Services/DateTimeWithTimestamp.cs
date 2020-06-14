using System;

namespace CoVid19Info.Services
{
    public static class DateTimeWithTimestamp
    {
        public static DateTime GetTodayTimestamp()
        {
            var timestamp = 1591993980565;

            return DateTimeOffset.FromUnixTimeMilliseconds(timestamp).Date;
        }

        public static bool IsTimestampToday(long time)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(time).Date == DateTime.Today;
        }
    }
}
