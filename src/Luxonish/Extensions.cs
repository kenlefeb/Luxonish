using System;

namespace Luxonish
{
    public static class Extensions
    {
        private static System.DateTime _epoch = new System.DateTime(170, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long ToMilliseconds(this System.DateTime datetime)
        {
            var elapsed = datetime - _epoch;
            return (long)elapsed.TotalMilliseconds;
        }

        public static System.DateTime ToSystemDateTime(this long milliseconds)
        {
            return _epoch.AddMilliseconds(milliseconds);
        }

    }
}
