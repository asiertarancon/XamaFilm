using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamaFilm.Converters
{
    public class RatingToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {            
            double rating = Double.Parse(value.ToString())/10;
            if (rating >= 9)
                return Color.DarkGoldenrod;
            else if (rating >= 8)
                return Color.DarkGreen;
            else if (rating >= 6)
                return Color.DarkOrange;
            else
                return Color.DarkRed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
