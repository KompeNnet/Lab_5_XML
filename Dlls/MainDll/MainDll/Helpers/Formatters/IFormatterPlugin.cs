namespace Lab_4.Helpers.Formatters
{
    public interface IFormatterPlugin
    {
        string GetStartType();
        string GetResultType();
        IFormatter GetFormatter();
    }
}
