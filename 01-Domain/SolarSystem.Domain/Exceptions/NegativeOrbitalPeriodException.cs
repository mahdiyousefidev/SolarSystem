namespace SolarSystem.Domain.Exceptions
{
    public class NegativePeriodException : Exception
    {
        public NegativePeriodException(string message = "Period could not be negative") : base(message)
        {

        }
    }
}
