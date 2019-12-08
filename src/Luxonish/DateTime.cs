namespace Luxonish
{
    /// <summary>
    ///     A DateTime is an immutable data structure representing a specific date and time and accompanying methods. It
    ///     contains class and instance methods for creating, parsing, interrogating, transforming, and formatting them.
    /// </summary>
    public class DateTime
    {
        /// <summary>
        ///     Get the day of the month (1-30ish).
        /// </summary>
        public int Day { get; }


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
        public int Hour { get; }


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
        public string Locale { get; }


        /// <summary>
        ///     Get the millisecond of the second (0-999).
        /// </summary>
        public int Millisecond { get; }


        /// <summary>
        ///     Get the minute of the hour (0-59).
        /// </summary>
        public int Minute { get; }


        /// <summary>
        ///     Get the month (1-12).
        /// </summary>
        public int Month { get; }


        /// <summary>
        ///     Get the human readable long month name, such as 'October'.
        /// </summary>
        public string MonthLong { get; }


        /// <summary>
        ///     Get the human readable short month name, such as 'Oct'.
        /// </summary>
        public string MonthShort { get; }


        /// <summary>
        ///     Get the numbering system of a DateTime, such 'beng'.
        /// </summary>
        public string NumberingSystem { get; }


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
        public string OutputCalendar { get; }


        /// <summary>
        ///     Get the quarter
        /// </summary>
        public int Quarter { get; }


        /// <summary>
        ///     Get the second of the minute (0-59).
        /// </summary>
        public int Second { get; }


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
        public int Year { get; }


        /// <summary>
        ///     Get the time zone associated with this DateTime.
        /// </summary>
        public Zone Zone { get; }


        /// <summary>
        ///     Get the name of the time zone.
        /// </summary>
        public string ZoneName { get; }
    }
}