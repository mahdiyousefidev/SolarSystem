namespace SolarSystem.Domain.Exceptions
{
    public class CelestialBodyNotExistException : Exception
    {
        public CelestialBodyNotExistException(string message = "The celestial body doesn't exist or already removed") : base(message)
        {

        }
    }

}
