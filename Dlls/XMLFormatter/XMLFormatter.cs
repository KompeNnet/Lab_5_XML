using System;

namespace Lab_4.Helpers.Formatters
{
    public class XMLFormatter : IFormatter
    {
        static string formatterRules = "";

        public bool IsCompatible(string extension)
        {
            return extension == "xml" ? true : false;
        }

        public string GetRules()
        {
            return formatterRules;
        }

        public void SetRules(string rules)
        {
            formatterRules = rules;
        }

        public string Format(string input)
        {
            //TODO
            throw new NotImplementedException();
        }

        public string ReFormat(string input)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
