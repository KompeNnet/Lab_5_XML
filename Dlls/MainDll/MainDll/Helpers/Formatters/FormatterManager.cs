using System;
using System.Collections.Generic;
using System.Windows;

namespace Lab_4.Helpers.Formatters
{
    class FormatterManager
    {
        public static bool LoadFormat(IFormatter formatter)
        {
            try
            {
                return true;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("It is already exists", "Can't add", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }
    }
}
