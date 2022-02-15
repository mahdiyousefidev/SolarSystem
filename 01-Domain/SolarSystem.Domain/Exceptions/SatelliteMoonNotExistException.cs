namespace SolarSystem.Domain.Exceptions
{
    public class SatelliteMoonNotExistException : Exception
    {
        public SatelliteMoonNotExistException(string message = "The satellite moon doesn't exist or already removed") : base(message)
        {

        }
    }

    public class CelestialBodyExistException : Exception
    {
        public CelestialBodyExistException(string message= "The celestial body has already added")
        {

        }
    }
    public class CelestialBodyNotExistException : Exception
    {
        public CelestialBodyNotExistException(string message = "The celestial body doesn't exist or already removed") : base(message)
        {

        }
    }

    public class NullCelestialBodyException : Exception
    {
        public NullCelestialBodyException(string message = "The celestial body could not be null") : base(message)
        {

        }
    }

}
