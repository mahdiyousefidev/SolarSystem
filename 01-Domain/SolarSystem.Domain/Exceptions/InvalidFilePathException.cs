namespace SolarSystem.Domain.Exceptions
{
    public class InvalidFileUrlException : Exception
    {
        public InvalidFileUrlException(string message = "The entered path is not valid") : base(message)
        {

        }
    }
}
