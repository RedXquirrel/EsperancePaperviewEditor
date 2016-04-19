using System;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.Converters
{
    public class MaskConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool response = false;

            double reading = System.Convert.ToDouble(value);
            double threshhold = System.Convert.ToDouble(parameter);

            if (reading >= threshhold) response = true;

            return response;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
