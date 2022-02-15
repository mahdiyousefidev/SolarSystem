namespace SolarSystem.Framework
{
    public class Mass
    {
        public Mass(long weight, MassUnit unit)
        {
            Weight = weight;
            Unit = unit;
        }

        public long Weight { get; set; }
        public MassUnit Unit { get; set; }
    }
}
