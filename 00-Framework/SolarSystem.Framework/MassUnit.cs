namespace SolarSystem.Framework
{
    public class MassUnit
    {
        public MassUnit(int baseValue, int power, string title )
        {
            BaseValue = baseValue;
            Power = power;
            Title = title;
        }
        public int Power { get; private set; }
        public int BaseValue { get; private set; }
        public string Title { get; private set; }

        // todo and the measure property
    }
}
