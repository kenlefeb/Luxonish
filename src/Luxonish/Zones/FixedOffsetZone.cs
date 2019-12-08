namespace Luxonish.Zones
{
    /// <summary>
    ///     A zone with a fixed offset (meaning no DST)
    /// </summary>
    public class FixedOffsetZone : Zone
    {
        public override bool IsValid { get; }
        public override string Name { get; }
        public override string Type { get; }
        public override bool Universal { get; }
    }
}
