using FormsChat.Helpers;
using SendBird;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsChat.Converters
{
    public class TypeToTextColorConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int parameterType = int.Parse(parameter.ToString());
            Xamarin.Forms.Color background = Color.Silver;
            var user = (User)value;
            var userName = Settings.UserId;
            if (user.UserId == userName)
            {
                background = Color.White;
                if (parameterType == 0)
                    background = Color.Black;
            }
            else
            {
                background = Color.Black;
                if (parameterType == 0)
                    background = Color.White;
            }

            return background;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw null;
        }
    }
}
