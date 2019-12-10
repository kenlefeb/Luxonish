using Luxonish.Zones;

namespace Luxonish
{
    public abstract class Zone
    {
        /// <summary>
        ///     Return whether this Zone is valid.
        /// </summary>
        public abstract bool IsValid { get; protected set; }


        /// <summary>
        ///     The name of this zone.
        /// </summary>
        public abstract string Name { get; protected set; }


        /// <summary>
        ///     The type of zone
        /// </summary>
        public abstract string Type { get; protected set; }


        /// <summary>
        ///     Returns whether the offset is known to be fixed for the whole year.
        /// </summary>
        public abstract bool Universal { get; protected set; }

        public static Zone Default => new WindowsZone(System.TimeZoneInfo.Local.Id);
        public static Zone Utc => new FixedOffsetZone("UTC");
    }
}