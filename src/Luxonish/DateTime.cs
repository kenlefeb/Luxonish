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
        private long _milliseconds;

        /// <summary>
        ///     Get the day of the month (1-30ish).
        /// </summary>
        public int Day => _milliseconds.ToSystemDateTime().Day;


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
        public int Hour => _milliseconds.ToSystemDateTime().Hour;


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
        public int Millisecond => _milliseconds.ToSystemDateTime().Millisecond;


        /// <summary>
        ///     Get the minute of the hour (0-59).
        /// </summary>
        public int Minute => _milliseconds.ToSystemDateTime().Minute;


        /// <summary>
        ///     Get the month (1-12).
        /// </summary>
        public int Month => _milliseconds.ToSystemDateTime().Month;


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
        public int Second => _milliseconds.ToSystemDateTime().Second;


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
        public int Year => _milliseconds.ToSystemDateTime().Year;


        /// <summary>
        ///     Get the time zone associated with this DateTime.
        /// </summary>
        public Zone Zone { get; private set; }

        public DateTime ToZone(Zone zone, bool keepLocalTime = false, bool keepCalendarTime = false)
        {
            if (zone == Zone)
                return this;

            if (!zone.IsValid)
                throw new ArgumentOutOfRangeException(nameof(zone), $"Invalid time zone (\"{zone.Name}\") specified");

            return this;

            /*
             *       let newTS = this.ts;
                  if (keepLocalTime || keepCalendarTime) {
                    const offsetGuess = this.o - zone.offset(this.ts);
                    const asObj = this.toObject();
                    [newTS] = objToTS(asObj, offsetGuess, zone);
                  }
                  return clone(this, { ts: newTS, zone });

             */
        }


        /// <summary>
        ///     Get the name of the time zone.
        /// </summary>
        public string ZoneName => Zone?.Name ?? "n/a";

        public static DateTime CreateLocal(int? year = null, int? month = null, int? day = null, int? hour = null, int? minute = null, int? second = null, int? millisecond = null, Zone? zone = null, Settings? settings = null)
        {
            if (zone == null)
                zone = Zone.Default;

            // TODO: Convert "Now" from the specified time zone to the Local time zone
            return Create(year, month, day, hour, minute, second, millisecond, zone, settings ?? Settings.Default, System.DateTime.Now);
        }

        private static DateTime Create(int? year, int? month, int? day, int? hour, int? minute, int? second, int? millisecond, Zone zone, Settings settings, System.DateTime now)
        {
            var datetime = (year.HasValue || month.HasValue || day.HasValue || hour.HasValue || minute.HasValue || second.HasValue || millisecond.HasValue)
                ? new System.DateTime(
                    year ?? 1,
                    month ?? 1,
                    day ?? 1,
                    hour ?? 0,
                    minute ?? 0,
                    second ?? 0,
                    millisecond ?? 0
                )
                : new System.DateTime
                (
                    now.Year,
                    now.Month,
                    now.Day,
                    now.Hour,
                    now.Minute,
                    now.Second,
                    now.Millisecond
                );
            return new DateTime
            {
                _milliseconds = datetime.ToMilliseconds(),
                Zone = zone,
                _settings = settings
            };
        }

        public static DateTime CreateUtc(int? year = null, int? month = null, int? day = null, int? hour = null, int? minute = null, int? second = null, int? millisecond = null, Settings? settings = null)
        {
            return Create(year, month, day, hour, minute, second, millisecond, Zone.Utc, settings, System.DateTime.UtcNow);
        }

        public System.DateTime ToSystemDateTime()
        {
            return _milliseconds.ToSystemDateTime();
        }

        public static DateTime FromSystemDateTime(in System.DateTime input, Zone? zone = null, Settings? settings = null)
        {
            if (input.Kind == DateTimeKind.Utc && (zone != null && zone != Zone.Utc))
                throw new ArgumentOutOfRangeException(nameof(zone), $"You may not specify the time zone \"{zone?.Name ?? "null"}\" along with a DateTime.Kind == Utc");

            return input.Kind == DateTimeKind.Utc
                ? CreateUtc(input.Year, input.Month, input.Day, input.Hour, input.Minute, input.Second, input.Millisecond, settings)
                : CreateLocal(input.Year, input.Month, input.Day, input.Hour, input.Minute, input.Second, input.Millisecond, zone: zone, settings);
        }

        public static DateTime FromMilliseconds(in long milliseconds, Zone? zone = null, Settings? settings = null)
        {
            var datetime = milliseconds.ToSystemDateTime();
            return FromSystemDateTime(datetime, zone, settings);
        }

        public long ToMilliseconds()
        {
            return _milliseconds;
        }
    }
}