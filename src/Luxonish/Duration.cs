namespace Luxonish
{
    /// <summary>
    ///     A Duration object represents a period of time, like "2 months" or "1 day, 1 hour". Conceptually, it's just a map of
    ///     units to their quantities, accompanied by some additional configuration and methods for creating, parsing,
    ///     interrogating, transforming, and formatting them. They can be used on their own or in conjunction with other Luxon
    ///     types; for example, you can use DateTime.plus to add a Duration object to a DateTime, producing another DateTime.
    /// </summary>
    public class Duration
    {
        /// <summary>
        ///     Get the days.
        /// </summary>
        public int Days { get; }


        /// <summary>
        ///     Get the hours.
        /// </summary>
        public int Hours { get; }


        /// <summary>
        ///     Returns an explanation of why this Duration became invalid, or null if the Duration is valid
        /// </summary>
        public string InvalidExplanation { get; }


        /// <summary>
        ///     Returns an error code if this Duration became invalid, or null if the Duration is valid
        /// </summary>
        public string InvalidReason { get; }


        /// <summary>
        ///     Returns whether the Duration is invalid.
        /// </summary>
        public bool IsValid { get; }


        /// <summary>
        ///     Get the locale of a Duration, such 'en-GB'
        /// </summary>
        public string Locale { get; }


        /// <summary>
        ///     Get the milliseconds.
        /// </summary>
        public int Milliseconds { get; }


        /// <summary>
        ///     Get the minutes.
        /// </summary>
        public int Minutes { get; }


        /// <summary>
        ///     Get the months.
        /// </summary>
        public int Months { get; }


        /// <summary>
        ///     Get the inting system of a Duration, such 'beng'.
        /// </summary>
        public string IntingSystem { get; }


        /// <summary>
        ///     Get the quarters.
        /// </summary>
        public int Quarters { get; }


        /// <summary>
        ///     Get the seconds.
        /// </summary>
        public int Seconds { get; }


        /// <summary>
        ///     Get the weeks
        /// </summary>
        public int Weeks { get; }


        /// <summary>
        ///     Get the years.
        /// </summary>
        public int Years { get; }
    }
}