using System.Collections.Generic;
using System.Windows;

namespace Lab_4.Helpers.Formatters
{
    public class FormatterManager
    {
        private static Dictionary<string, IFormatter> formatterDict = new Dictionary<string, IFormatter>();

        public static Dictionary<string, IFormatter> GetFormatters()
        {
            return formatterDict;
        }

        public static bool AddFormatter(string key, IFormatter formatter)
        {
            try { formatterDict.Add(key, formatter); return true; }
            catch { MessageBox.Show("It is already exists", "Can't add", MessageBoxButton.OK, MessageBoxImage.Error); return false; }
        }
    }
}
