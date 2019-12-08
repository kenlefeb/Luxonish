namespace Luxonish.Zones
{
    /// <summary>
    ///     A zone that failed to parse. You should never need to instantiate this.
    /// </summary>
    public class InvalidZone : Zone
    {
        public override bool IsValid { get; }
        public override string Name { get; }
        public override string Type { get; }
        public override bool Universal { get; }
    }
}
