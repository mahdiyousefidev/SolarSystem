﻿using SolarSystem.Domain.Base;
using SolarSystem.Framework;

namespace SolarSystem.Domain
{
    public class Saturn : GasGiant
    {
        public Saturn(string name = "Saturn", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            ChangeOrbitalPeriod(new Period(29, new PeriodUnit("years")));

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
