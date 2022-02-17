﻿using SolarSystem.Domain.Base;
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
            AddSatellite(new Jupiter());
            AddSatellite(new Saturn());
            AddSatellite(new Uranus());
            AddSatellite(new Neptune());
            AddSatellite(new Ceres());
            AddSatellite(new Pluto());
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
