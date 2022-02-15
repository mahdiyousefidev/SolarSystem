using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class Uranus : IceGiant
    {
        public Uranus(string name = "Uranus", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangeOrbitalPeriod(new Period(84, new PeriodUnit("years")));
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
