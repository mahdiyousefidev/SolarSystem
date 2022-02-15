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

        public override string ToString()
        {
            return $"{Value} {Unit.Title}";
        }

        public long GetValue()
        {
            return Value * Unit.ToDay();
        }
    }
}
