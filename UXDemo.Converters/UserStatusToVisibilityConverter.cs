using NET.efilnukefesin.Apps.UXDemo.Models.Enums;
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
    public class UserStatusToVisibilityConverter : IValueConverter
    {
        #region Methods

        #region Convert
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility result = Visibility.Visible;
            if (value is UserStatus)
            {
                if ((UserStatus)value == UserStatus.None)
                {
                    result = Visibility.Collapsed;
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

        #endregion Methods
    }
}
