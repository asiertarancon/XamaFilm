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
                return Color.Gold;
            else if (rating >= 8)
                return Color.Green;
            else if (rating >= 6)
                return Color.Orange;
            else
                return Color.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
