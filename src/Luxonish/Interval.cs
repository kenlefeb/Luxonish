namespace Luxonish
{
    /// <summary>
    ///     An Interval object represents a half-open interval of time, where each endpoint is a DateTime. Conceptually, it's a
    ///     container for those two endpoints, accompanied by methods for creating, parsing, interrogating, comparing,
    ///     transforming, and formatting them.
    /// </summary>
    public class Interval
    {
        /// <summary>
        ///     Returns the end of the Interval
        /// </summary>
        public DateTime End { get; }


        /// <summary>
        ///     Returns an explanation of why this Interval became invalid, or null if the Interval is valid
        /// </summary>
        public string InvalidExplanation { get; }


        /// <summary>
        ///     Returns an error code if this Interval is invalid, or null if the Interval is valid
        /// </summary>
        public string InvalidReason { get; }


        /// <summary>
        ///     Returns whether this Interval's end is at least its start, meaning that the Interval isn't 'backwards'.
        /// </summary>
        public bool IsValid { get; }


        /// <summary>
        ///     Returns the start of the Interval
        /// </summary>
        public DateTime Start { get; }
    }
}