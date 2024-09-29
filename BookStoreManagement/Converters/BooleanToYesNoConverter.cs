// BooleanToYesNoConverter.cs
using System;
using System.Globalization;
using System.Windows.Data;

namespace BookStoreManagement.Converters
{
    public class BooleanToYesNoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return boolValue ? "Yes" : "No";
            }
            return "No";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string strValue)
            {
                return strValue.Equals("Yes", StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }
    }
}
