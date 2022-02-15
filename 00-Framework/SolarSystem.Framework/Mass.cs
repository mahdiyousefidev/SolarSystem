namespace SolarSystem.Framework
{
    public class Mass
    {
        public Mass(double weight, MassUnit unit)
        {
            Weight = weight;
            Unit = unit;
        }

        public double Weight { get; private set; }
        public MassUnit Unit { get; private set; }

        public override string ToString()
        {
            return $"{Weight} {Unit.BaseValue}^{Unit.Power} {Unit.Title}";
        }
    }
}
