namespace SolarSystem.Framework
{
    public class Mass
    {
        public Mass(double weight, MassUnit unit)
        {
            Weight = weight;
            Unit = unit;
        }

        private double Weight { get; set; }
        private MassUnit Unit { get; set; }

        public override string ToString()
        {
            return $"{Weight} {Unit.BaseValue}^{Unit.Power} {Unit.Type}";
        }

        public double GetValue()
        {
            return Math.Floor(Math.Pow(Unit.BaseValue, Unit.Power) * Weight);
        }
    }
}
