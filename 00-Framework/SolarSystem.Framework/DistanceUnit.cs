namespace SolarSystem.Framework
{
    public class DistanceUnit
    {
        public DistanceUnit(DistanceUnitType type)
        {
            Type = type;
        }
        public DistanceUnitType Type { get; set; }
        // todo and the measure property
    }
}
