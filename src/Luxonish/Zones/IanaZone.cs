namespace Luxonish.Zones
{
    /// <summary>
    ///     A zone identified by an IANA identifier, like America/New_York
    /// </summary>
    public class IanaZone : Zone
    {
        public override bool IsValid { get; }
        public override string Name { get; }
        public override string Type { get; }
        public override bool Universal { get; }
    }
}