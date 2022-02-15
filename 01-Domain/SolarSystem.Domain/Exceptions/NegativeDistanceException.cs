namespace SolarSystem.Domain.Exceptions
{
    public class NegativeDistanceException : Exception
    {
        public NegativeDistanceException(string message = "Distance could not be negative") : base(message)
        {

        }
    }
}
