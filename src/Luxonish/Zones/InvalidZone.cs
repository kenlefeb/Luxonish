namespace Luxonish.Zones
{
    /// <summary>
    ///     A zone that failed to parse. You should never need to instantiate this.
    /// </summary>
    public class InvalidZone : Zone
    {
        public override bool IsValid { get; protected set; }
        public override string Name { get; protected set; }
        public override string Type { get; protected set; }
        public override bool Universal { get; protected set; }
    }
}
