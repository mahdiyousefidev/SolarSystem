namespace SolarSystem.Framework
{
    public class Distance
    {
        public Distance(long length, DistanceUnit unit)
        {
            Length = length;
            Unit = unit;
        }

        private long Length { get; set; }
        private DistanceUnit Unit { get; set; }

        public override string ToString()
        {
            return $"{Length} {Unit.Type}";
        }

        public long GetValue()
        {
            return Length;
        }
    }
}
