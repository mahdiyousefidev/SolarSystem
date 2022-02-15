namespace SolarSystem.Domain.Exceptions
{
    public class PictureNotExistException : Exception
    {
        public PictureNotExistException(string message = "Picture doesn't exist") : base(message)
        {

        }
    }
}
