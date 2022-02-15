using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class Sun : Star
    {
        public Sun(string name = "Sun", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            AddSatelliteMoon(new Mercury());
            AddSatelliteMoon(new Venus());
            AddSatelliteMoon(new Earth());
            AddSatelliteMoon(new Mars());
            AddSatelliteMoon(new Jupiter());
            AddSatelliteMoon(new Saturn());
            AddSatelliteMoon(new Uranus());
            AddSatelliteMoon(new Neptune());
            AddSatelliteMoon(new Ceres());
            AddSatelliteMoon(new Pluto());
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
