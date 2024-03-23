namespace Containers.Exceptions;

public class UnsupportedCargoException:Exception
{
    public UnsupportedCargoException()
    {
    }

    public UnsupportedCargoException(string? message) : base(message)
    {
    }

    public UnsupportedCargoException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}