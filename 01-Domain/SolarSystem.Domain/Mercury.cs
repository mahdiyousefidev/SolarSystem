using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class Mercury : TerrestrialPlanet
    {
        public Mercury(string name = "Mercury", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangeOrbitalPeriod(new Period(88, new PeriodUnit(PeriodUnitType.day)));

        }
        public override bool CanBeTerraformed()
        {
            return GetType().IsSubclassOf(typeof(TerrestrialPlanet));
        }

        public override bool CanSustainLife()
        {
            return GetType().Equals(typeof(Earth));
        }
    }
}
