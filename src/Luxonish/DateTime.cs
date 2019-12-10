using System;

namespace Luxonish
{
    /// <summary>
    ///     A DateTime is an immutable data structure representing a specific date and time and accompanying methods. It
    ///     contains class and instance methods for creating, parsing, interrogating, transforming, and formatting them.
    /// </summary>
    public class DateTime
    {
        private Settings _settings = Settings.Default;

        /// <summary>
        ///     Get the day of the month (1-30ish).
        /// </summary>
        public int Day { get; private set; }


        /// <summary>
        ///     Returns the number of days in this DateTime's month
        /// </summary>
        public int DaysInMonth { get; }


        /// <summary>
        ///     Returns the number of days in this DateTime's year
        /// </summary>
        public int DaysInYear { get; }


        /// <summary>
        ///     Get the hour of the day (0-23).
        /// </summary>
        public int Hour { get; private set; }


        /// <summary>
        ///     Returns an explanation of why this DateTime became invalid, or null if the DateTime is valid
        /// </summary>
        public string InvalidExplanation { get; }


        /// <summary>
        ///     Returns an error code if this DateTime is invalid, or null if the DateTime is valid
        /// </summary>
        public string InvalidReason { get; }


        /// <summary>
        ///     Get whether the DateTime is in a DST.
        /// </summary>
        public bool IsInDst { get; }


        /// <summary>
        ///     Returns true if this DateTime is in a leap year, false otherwise
        /// </summary>
        public bool IsInLeapYear { get; }


        /// <summary>
        ///     Get whether this zone's offset ever changes, as in a DST.
        /// </summary>
        public bool IsOffsetFixed { get; }


        /// <summary>
        ///     Returns whether the DateTime is valid.
        /// </summary>
        public bool IsValid { get; }


        /// <summary>
        ///     Get the locale of a DateTime, such 'en-GB'.
        /// </summary>
        public string Locale => _settings.DefaultLocale;


        /// <summary>
        ///     Get the millisecond of the second (0-999).
        /// </summary>
        public int Millisecond { get; private set; }


        /// <summary>
        ///     Get the minute of the hour (0-59).
        /// </summary>
        public int Minute { get; private set; }


        /// <summary>
        ///     Get the month (1-12).
        /// </summary>
        public int Month { get; private set; }


        /// <summary>
        ///     Get the human readable long month name, such as 'October'.
        /// </summary>
        public string MonthLong { get; }


        /// <summary>
        ///     Get the human readable short month name, such as 'Oct'.
        /// </summary>
        public string MonthShort { get; }


        /// <summary>
        ///     Get the numbering system of a DateTime, such 'beng'. 'auto' means the Internationalization API will automatically determine which numbering system to use.
        /// </summary>
        public string NumberingSystem => _settings.DefaultNumberingSystem;


        /// <summary>
        ///     Get the UTC offset of this DateTime in minutes
        /// </summary>
        public int Offset { get; }


        /// <summary>
        ///     Get the long human name for the zone's current offset, for example "Eastern Standard Time" or "Eastern Daylight
        ///     Time". Defaults to the system's locale if no locale has been specified
        /// </summary>
        public string OffsetNameLong { get; }


        /// <summary>
        ///     Get the short human name for the zone's current offset, for example "EST" or "EDT". Defaults to the system's locale
        ///     if no locale has been specified
        /// </summary>
        public string OffsetNameShort { get; }

        /// <summary>
        ///     Get the ordinal (meaning the day of the year)
        /// </summary>
        public int Ordinal { get; }


        /// <summary>
        ///     Get the output calendar of a DateTime, such 'islamic'.
        /// </summary>
        public string OutputCalendar => _settings.DefaultOutputCalendar;


        /// <summary>
        ///     Get the quarter
        /// </summary>
        public int Quarter { get; }


        /// <summary>
        ///     Get the second of the minute (0-59).
        /// </summary>
        public int Second { get; private set; }


        /// <summary>
        ///     Get the week number of the week year (1-52ish).
        /// </summary>
        public int WeekNumber { get; }


        /// <summary>
        ///     Get the week year
        /// </summary>
        public int WeekYear { get; }


        /// <summary>
        ///     Get the day of the week.
        /// </summary>
        public int Weekday { get; }


        /// <summary>
        ///     Get the human readable long weekday, such as 'Monday'.
        /// </summary>
        public string WeekdayLong { get; }


        /// <summary>
        ///     Get the human readable short weekday, such as 'Mon'.
        /// </summary>
        public string WeekdayShort { get; }


        /// <summary>
        ///     Returns the number of weeks in this DateTime's year
        /// </summary>
        public int WeeksInWeekYear { get; }


        /// <summary>
        ///     Get the year
        /// </summary>
        public int Year { get; private set; }


        /// <summary>
        ///     Get the time zone associated with this DateTime.
        /// </summary>
        public Zone Zone { get; }


        /// <summary>
        ///     Get the name of the time zone.
        /// </summary>
        public string ZoneName { get; }

        public static DateTime CreateLocal(int? year = null, int? month = null, int? day = null, int? hour = null, int? minute = null, int? second = null, int? millisecond = null, Settings? settings = null)
        {
            var now = System.DateTime.Now;
            return (year.HasValue || month.HasValue || day.HasValue || hour.HasValue || minute.HasValue || second.HasValue || millisecond.HasValue)
                ? new DateTime
                {
                    Year = year ?? 1,
                    Month = month ?? 1,
                    Day = day ?? 1,
                    Hour = hour ?? 0,
                    Minute = minute ?? 0,
                    Second = second ?? 0,
                    Millisecond = millisecond ?? 0,
                    _settings = settings ?? Settings.Default
                }
                : new DateTime
                {
                    Year = now.Year,
                    Month = now.Month,
                    Day = now.Day,
                    Hour = now.Hour,
                    Minute = now.Minute,
                    Second = now.Second,
                    Millisecond = now.Millisecond,
                    _settings = settings ?? Settings.Default
                };
        }

        public static DateTime CreateUtc(int year = 1, int month = 1, int day = 1, int hour = 0, int minute = 0, int second = 0, int millisecond = 0, Settings? settings = null)
        {
            throw new NotImplementedException();
        }

        public System.DateTime ToSystemDateTime()
        {
            return new System.DateTime(Year, Month, Day, Hour, Minute, Second, Millisecond);
        }
    }
}