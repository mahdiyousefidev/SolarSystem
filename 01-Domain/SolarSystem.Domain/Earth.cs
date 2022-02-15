using SolarSystem.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Domain
{
    public class Earth : TerrestrialPlanet
    {
        public override bool CanBeTerraformed()
        {
            throw new NotImplementedException();
        }

        public override bool CanSustainLife()
        {
            throw new NotImplementedException();
        }

        public override bool HasSatelliteMoon()
        {
            throw new NotImplementedException();
        }
    }
}
