using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_4.Helpers.Formatters
{
    public class HTMLFormatterPlugin : IFormatterPlugin
    {
        private string ResultType = "html";
        private HTMLFormatter formatter = new HTMLFormatter();

        public IFormatter GetFormatter()
        {
            return formatter;
        }

        public string GetResultType()
        {
            return ResultType;
        }
    }
}
