namespace Containers.Exceptions;

public class NoSuchContainerException:Exception
{
    public NoSuchContainerException()
    {
    }

    public NoSuchContainerException(string? message) : base(message)
    {
    }

    public NoSuchContainerException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}