namespace SolarSystem.Domain.Exceptions
{
    public class EmptyPictureUrlException : Exception
    {
        public EmptyPictureUrlException(string message = "Picture url could not be empty") : base(message)
        {

        }
    }
}
