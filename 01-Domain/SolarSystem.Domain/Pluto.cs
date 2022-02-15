using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class Pluto : DwarfPlanet
    {
        public Pluto(string name = "Pluto", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangeOrbitalPeriod(new Period(248, new PeriodUnit("years")));

        }

        public override bool CanBeTerraformed()
        {
            return false;
        }

        public override bool CanSustainLife()
        {
            return false;
        }
    }
}
