using FormsChat.Helpers;
using SendBird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsChat.Converters
{
    public class TypeToColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int column = 0;
            var user = (User)value;
            var userName = Settings.UserId;
            if (user.UserId != userName)
            {
                column = 0;
            }
            else
            {
                column = 1;
            }
            return column;

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
