using System;

namespace Lab_4.Helpers.Formatters
{
    public class IPlugin : IFormatterPlugin
    {
        string startType = "json";
        string resultType = "xml";

        public string GetStartType()
        {
            return startType;
        }

        public string GetResultType()
        {
            return resultType;
        }

        public IFormatter GetFormatter()
        {
            return new XMLFormatter();
        }
    }
}
