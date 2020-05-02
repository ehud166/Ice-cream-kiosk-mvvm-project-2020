using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace IceCreamKiosk.Converters
{
    public class SocailMediaUrlToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            string url = value.ToString().ToLower();
            if (url.Contains("facebook"))
                return "Facebook";
            if (url.Contains("google"))
                return "Google";
            if (url.Contains("twitter"))
                return "Twitter";
            if (url.Contains("instagram"))
                return "Instagram";
            if (url.Contains("linkedin"))
                return "Linkedin";

            return "Web";
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
