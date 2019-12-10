namespace Luxonish.Zones
{
    /// <summary>
    ///     A zone identified by an IANA identifier, like America/New_York
    /// </summary>
    public class IanaZone : Zone
    {
        public IanaZone(string name)
        {
            Name = name;
        }
        public override bool IsValid { get; protected set; }
        public override string Name { get; protected set; }
        public override string Type { get; protected set; }
        public override bool Universal { get; protected set; }
    }
}