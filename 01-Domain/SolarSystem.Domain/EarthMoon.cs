using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    internal class EarthMoon : TerrestrialPlanet
    {
        public EarthMoon(string name = "Moon", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {

        }

        public override bool CanBeTerraformed()
        {
            return true;
        }

        public override bool CanSustainLife()
        {
            return false;
        }
    }
}
