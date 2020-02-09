using System;

namespace Luxonish.Zones
{
    /// <summary>
    ///     A zone with a fixed offset (meaning no DST)
    /// </summary>
    public class FixedOffsetZone : Zone
    {
        private TimeZoneInfo _zone;

        public FixedOffsetZone(string id)
        {
            _zone = System.TimeZoneInfo.FindSystemTimeZoneById(id);
            IsValid = true;
            Name = id;
            Universal = true;
        }

        public override bool IsValid { get; protected set; }
        public override string Name { get; protected set; }
        public override string Type { get; protected set; }
        public override bool Universal { get; protected set; }
    }
}
