using SolarSystem.Domain.Base;
using SolarSystem.Domain.Infrastructures;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class Sun : Star
    {
        public Sun(string name = "Sun", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            AddSatellite(new Mercury());
            AddSatellite(new Venus());
            AddSatellite(new Earth());
            AddSatellite(new Mars());
            AddSatellite(new Ceres());
            AddSatellite(new Jupiter());
            AddSatellite(new Saturn());
            AddSatellite(new Uranus());
            AddSatellite(new Neptune());
            AddSatellite(new Pluto());
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
