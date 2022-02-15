namespace SolarSystem.Domain.Exceptions
{
    public class NullDistanceException : Exception
    {
        public NullDistanceException(string message = "Distance could not be null") : base(message)
        {

        }
    }
}
