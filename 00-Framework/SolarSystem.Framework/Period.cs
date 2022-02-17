namespace SolarSystem.Framework
{
    public class Period
    {
        public Period(long value, PeriodUnit unit)
        {
            Value = value;
            Unit = unit;
        }

        private long Value { get; set; }
        private PeriodUnit Unit { get; set; }

        public override string ToString()
        {
            return $"{Value} {Unit.Type}";
        }

        public long GetValue()
        {
            return Value * Unit.DayCount();
        }
    }
}
