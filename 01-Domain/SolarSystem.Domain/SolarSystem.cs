using SolarSystem.Domain.Base;

namespace SolarSystem.Domain
{
    public class SolarSystem : PlanetarySystem
    {
        public SolarSystem()
        {
            AddCelestialBody(new Sun());
        }
    }
}
