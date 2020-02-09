using System;

namespace Luxonish.Zones
{
    public class WindowsZone : Zone
    {
        private TimeZoneInfo _info;

        public WindowsZone(string id)
        {
            _info = System.TimeZoneInfo.FindSystemTimeZoneById(id);

            if (_info == null)
                throw new System.ArgumentOutOfRangeException(nameof(id), $"No Windows time zone can be found with the id \"{id}\"");

            IsValid = true;
            Name = _info.Id;
            Universal = !_info.SupportsDaylightSavingTime;
        }
        public override bool IsValid { get; protected set; }
        public override string Name { get; protected set; }
        public override string Type { get; protected set; }
        public override bool Universal { get; protected set; }
    }
}