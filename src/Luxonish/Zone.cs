namespace Luxonish
{
    public abstract class Zone
    {
        /// <summary>
        ///     Return whether this Zone is valid.
        /// </summary>
        public abstract bool IsValid { get; }


        /// <summary>
        ///     The name of this zone.
        /// </summary>
        public abstract string Name { get; }


        /// <summary>
        ///     The type of zone
        /// </summary>
        public abstract string Type { get; }


        /// <summary>
        ///     Returns whether the offset is known to be fixed for the whole year.
        /// </summary>
        public abstract bool Universal { get; }
    }
}