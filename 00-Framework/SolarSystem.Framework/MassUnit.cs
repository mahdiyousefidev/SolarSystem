namespace SolarSystem.Framework
{
    public class MassUnit
    {
        public MassUnit(int baseValue, int power, MassUnitType type )
        {
            BaseValue = baseValue;
            Power = power;
            Type = type;
        }
        public int Power { get; private set; }
        public int BaseValue { get; private set; }
        public MassUnitType Type { get; private set; }

        // todo and the measure property
        
    }
}
