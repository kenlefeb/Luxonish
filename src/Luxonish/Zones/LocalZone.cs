namespace Luxonish.Zones
{
    /// <summary>
    ///     Represents the local zone for the current process.
    /// </summary>
    public class LocalZone : Zone
    {
        public override bool IsValid { get; }
        public override string Name { get; }
        public override string Type { get; }
        public override bool Universal { get; }
    }
}
