using SolarSystem.Framework;

namespace SolarSystem.Domain.Base
{
    public abstract class DwarfPlanet : CelestialBody
    {
        public DwarfPlanet(string name, string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {

        }
    }
}
