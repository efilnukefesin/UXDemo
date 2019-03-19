using NET.efilnukefesin.Apps.UXDemo.Basics.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace NET.efilnukefesin.Apps.UXDemo.Converters
{
    public class ButtonStatusToVisibilityConverter : IValueConverter
    {
        #region Convert
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility result = Visibility.Visible;

            if (value is ButtonState)
            {
                switch ((ButtonState)value)
                {
                    case ButtonState.Normal:
                        result = Visibility.Collapsed;
                        break;
                    case ButtonState.Disabled:
                        break;
                    case ButtonState.Hovered:
                        break;
                    case ButtonState.Selected:
                        break;
                    default:
                        break;
                }
            }

            return result;
        }
        #endregion Convert

        #region ConvertBack
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion ConvertBack
    }
}
