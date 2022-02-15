namespace SolarSystem.Framework
{
    public class Period
    {
        public Period(long value, PeriodUnit unit)
        {
            Value = value;
            Unit = unit;
        }

        public long Value { get; set; }
        public PeriodUnit Unit { get; set; }
    }
}
