namespace Lab02.Data.Services;

public class DataOperationException : Exception
{
    public DataOperationException(string message, Exception? innerException = null)
        : base(message, innerException)
    {
    }
}