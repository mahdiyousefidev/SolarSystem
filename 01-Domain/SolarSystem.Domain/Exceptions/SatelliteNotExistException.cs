namespace SolarSystem.Domain.Exceptions
{
    public class SatelliteNotExistException : Exception
    {
        public SatelliteNotExistException(string message = "The satellite doesn't exist or already removed") : base(message)
        {

        }
    }

}
