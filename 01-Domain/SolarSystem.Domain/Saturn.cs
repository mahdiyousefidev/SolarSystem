using SolarSystem.Domain.Base;
using SolarSystem.Domain.Infrastructures;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class Saturn : GasGiant
    {
        public Saturn(string name = "Saturn", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangeOrbitalPeriod(new Period(29, new PeriodUnit(PeriodUnitType.year)));
            this.Colonize();
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
