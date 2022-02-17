namespace SolarSystem.Framework
{
    public class PeriodUnit
    {
        public PeriodUnit(PeriodUnitType type)
        {
            Type = type;
        }
        public PeriodUnitType Type { get; set; }
        // todo and the measure property

        public int DayCount()
        {
            return (int)Type;
        }
    }
}