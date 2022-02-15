namespace SolarSystem.Domain.Exceptions
{
    public class SatelliteMoonExistException : Exception
    {
        public SatelliteMoonExistException(string message = "The satellite moon has already added") : base(message)
        {

        }
    }
}
