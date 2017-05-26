using Newtonsoft.Json;
using System;

namespace Lab_4.Helpers.Formatters
{
    class XMLFormatter : IFormatter
    {
        public string Format(string input)
        {
            return JsonConvert.DeserializeXmlNode(input).ToString();
        }
    }
}
