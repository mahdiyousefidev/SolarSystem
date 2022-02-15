namespace SolarSystem.Domain.Exceptions
{
    public class EmptyNameException : Exception
    {
        public EmptyNameException(string name = "Name could not be empty") : base(name)
        {

        }
    }
}
