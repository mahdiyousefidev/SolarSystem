namespace SolarSystem.Domain.Exceptions
{
    public class CelestialBodyExistException : Exception
    {
        public CelestialBodyExistException(string message= "The celestial body has already added")
        {

        }
    }

}
