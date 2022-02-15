using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class Ceres : DwarfPlanet
    {
        public Ceres(string name = "Ceres", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangeOrbitalPeriod(new Period(1682, new PeriodUnit("days")));
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
