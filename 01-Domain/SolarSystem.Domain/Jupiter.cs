using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    internal class Jupiter : GasGiant
    {
        public Jupiter(string name = "Jupiter", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangeOrbitalPeriod(new Period(12, new PeriodUnit("years")));
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
