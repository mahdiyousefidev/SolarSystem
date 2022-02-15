using SolarSystem.Domain.Base;

namespace SolarSystem.Domain
{
    public class Saturn : GasGiant
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
