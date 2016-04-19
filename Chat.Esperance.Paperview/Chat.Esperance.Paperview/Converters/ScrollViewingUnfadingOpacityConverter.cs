using System;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.Converters
{
    public class ScrollViewingUnfadingOpacityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double input = System.Convert.ToDouble(value);
            double scale = System.Convert.ToDouble(parameter);

            double result = 1 - ((scale - input) / scale);

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
