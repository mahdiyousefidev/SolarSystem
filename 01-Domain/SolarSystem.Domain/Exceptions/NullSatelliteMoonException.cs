namespace SolarSystem.Domain.Exceptions
{
    public class NullSatelliteMoonException : Exception
    {
        public NullSatelliteMoonException(string message = "Satellite moon could not be null") : base(message)
        {

        }
    }
}
