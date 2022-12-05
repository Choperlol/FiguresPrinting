using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace FiguresPrinting.Helpers
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visibility = Visibility.Hidden;
            if (value is not null && value is bool boolValue)
                visibility = boolValue ? Visibility.Visible : Visibility.Hidden;
            return visibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
