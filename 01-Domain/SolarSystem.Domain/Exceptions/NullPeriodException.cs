namespace SolarSystem.Domain.Exceptions
{
    public class NullPeriodException : Exception
    {
        public NullPeriodException(string message = "Period could not be null") : base(message)
        {

        }
    }
}
