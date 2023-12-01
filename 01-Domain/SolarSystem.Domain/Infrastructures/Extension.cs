using SolarSystem.Domain.Base;

namespace SolarSystem.Domain.Infrastructures
{
    public static class Extension
    {
        public static bool Colonize(this CelestialBody celestialBody)
        {
            return celestialBody.CanBeTerraformed() && celestialBody.CanSustainLife() && celestialBody.HasSatelliteMoon();
        }
    }
}
