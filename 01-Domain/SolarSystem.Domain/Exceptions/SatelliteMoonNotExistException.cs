namespace SolarSystem.Domain.Exceptions
{
    public class SatelliteMoonNotExistException : Exception
    {
        public SatelliteMoonNotExistException(string message = "The satellite moon doesn't exist or already removed") : base(message)
        {

        }
    }
}
