using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class EarthMoon : TerrestrialPlanet
    {
        public EarthMoon(string name = "Moon", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangeOrbitalPeriod(new Period(27, new PeriodUnit(PeriodUnitType.day)));
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
