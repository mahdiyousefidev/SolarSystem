namespace SolarSystem.Domain.Exceptions
{
    public class NullSatelliteException : Exception
    {
        public NullSatelliteException(string message = "Satellite could not be null") : base(message)
        {

        }
    }
}
