using NET.efilnukefesin.Apps.UXDemo.Basics.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace NET.efilnukefesin.Apps.UXDemo.Converters
{
    public class StyleFromStateMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            ButtonState? dataValue = values[0] as ButtonState?;
            Style firstStyle = values[1] as Style;
            Style secondStyle = values[2] as Style;

            if (dataValue.Equals(ButtonState.Normal))
            {
                return firstStyle;
            }
            else
            {
                return secondStyle;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
