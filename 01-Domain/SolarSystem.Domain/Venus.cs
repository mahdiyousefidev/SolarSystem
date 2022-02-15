﻿using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class Venus : TerrestrialPlanet
    {
        public Venus(string name = "Venus", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {

        }

        public override bool CanBeTerraformed()
        {
            return true;
        }

        public override bool CanSustainLife()
        {
            return false;
        }
    }
}
