using NET.efilnukefesin.Apps.UXDemo.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace NET.efilnukefesin.Apps.UXDemo.Converters
{
    public class StyleFromUserStatusMultiConverter : IMultiValueConverter
    {
        #region Convert
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Style result = null;

            UserStatus? dataValue = values[0] as UserStatus?;

            if (dataValue != null)
            {
                switch (dataValue)
                {
                    case UserStatus.Online:
                        result = values[1] as Style;
                        break;
                    case UserStatus.Away:
                        result = values[2] as Style;
                        break;
                    case UserStatus.Busy:
                        result = values[3] as Style;
                        break;
                    default:
                        break;
                }
            }
            
            return result;
        }
        #endregion Convert

        #region ConvertBack
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
        #endregion ConvertBack
    }
}
