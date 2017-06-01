using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Lab_4.Helpers.Formatters
{
    public class FormatterManager
    {
        private static Dictionary<string, IFormatter> formatterDict = new Dictionary<string, IFormatter>();

        private static List<MenuItem> menuItemList = new List<MenuItem>();

        public static void AddMenuItem(MenuItem newItem)
        {
            menuItemList.Add(newItem);
        }

        public static List<MenuItem> GetMenuItems()
        {
            return menuItemList;
        }

        public static Dictionary<string, IFormatter> GetFormatters()
        {
            return formatterDict;
        }

        public static IFormatter GetByKey(string key)
        {
            return formatterDict[key];
        }

        public static bool AddFormatter(string key, IFormatter formatter, MenuItem newItem)
        {
            try { formatterDict.Add(key, formatter); menuItemList.Add(newItem); return true; }
            catch { MessageBox.Show("It is already exists", "Can't add", MessageBoxButton.OK, MessageBoxImage.Error); return false; }
        }
    }
}
