namespace SolarSystem.Domain.Exceptions
{
    public class NullCelestialBodyException : Exception
    {
        public NullCelestialBodyException(string message = "The celestial body could not be null") : base(message)
        {

        }
    }

}
