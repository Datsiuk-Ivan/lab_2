namespace Lab02.Data.Services;

public class DataValidationException : Exception
{
    public DataValidationException(List<string> errors)
        : base(string.Join(Environment.NewLine, errors))
    {
    }
}
