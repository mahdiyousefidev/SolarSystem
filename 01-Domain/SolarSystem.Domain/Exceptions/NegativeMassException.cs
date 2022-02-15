namespace SolarSystem.Domain.Exceptions
{
    public class NegativeMassException : Exception
    {
        public NegativeMassException(string message = "Mass could not be negative") : base(message)
        {

        }
    }
}
