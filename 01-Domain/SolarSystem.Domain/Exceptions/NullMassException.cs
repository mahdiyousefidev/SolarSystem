namespace SolarSystem.Domain.Exceptions
{
    public class NullMassException : Exception
    {
        public NullMassException(string message = "Mass could not be null") : base(message)
        {

        }
    }
}
