using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class EarthMoon : TerrestrialPlanet
    {
        public EarthMoon(string name = "Moon", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangeOrbitalPeriod(new Period(27, new PeriodUnit("days")));
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
