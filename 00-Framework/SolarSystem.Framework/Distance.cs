namespace SolarSystem.Framework
{
    public class Distance
    {
        public Distance(long length, DistanceUnit unit)
        {
            Length = length;
            Unit = unit;
        }

        public long Length { get; set; }
        public DistanceUnit Unit { get; set; }

        public override string ToString()
        {
            return $"{Length} {Unit.Title}";
        }
    }
}
