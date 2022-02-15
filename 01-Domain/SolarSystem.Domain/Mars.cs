using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class Mars : TerrestrialPlanet
    {
        public Mars(string name = "Mars", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangeOrbitalPeriod(new Period(687, new PeriodUnit("days")));

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
