using System.Windows.Controls;

namespace Lab_4.Helpers.Formatters
{
    class XMLFormatterPlugin : IFormatterPlugin
    {
        private XMLFormatter formatter = new XMLFormatter();

        public IFormatter GetFormatter()
        {
            return formatter;
        }
    }
}
