using SolarSystem.Domain.Base;
using SolarSystem.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Domain
{
    public class Earth : TerrestrialPlanet
    {
        public Earth(string name = "Earth", string picture = "", Mass? mass = null, Period? orbitalPeriod = null, Distance? distanceFromTheOrbitingCenter = null) : base(name, picture, mass, orbitalPeriod, distanceFromTheOrbitingCenter)
        {
            AddSatelliteMoon(new EarthMoon());
        }

        public override bool CanBeTerraformed()
        {
            return true;
        }

        public override bool CanSustainLife()
        {
            return true;
        }
    }
}
