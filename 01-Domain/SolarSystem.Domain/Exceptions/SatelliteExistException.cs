namespace SolarSystem.Domain.Exceptions
{
    public class SatelliteExistException : Exception
    {
        public SatelliteExistException(string message = "The satellite has already added") : base(message)
        {

        }
    }
}
