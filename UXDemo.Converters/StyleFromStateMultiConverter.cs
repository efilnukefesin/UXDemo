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
            Style result = null;

            ButtonState? dataValue = values[0] as ButtonState?;
            Style firstStyle = values[1] as Style;
            Style secondStyle = values[2] as Style;
            Style selectedStyle = values[3] as Style;

            if (dataValue.Equals(ButtonState.Normal))
            {
                result = firstStyle;
            }
            else if (dataValue.Equals(ButtonState.Hovered))
            {
                result = secondStyle;
            }
            else if (dataValue.Equals(ButtonState.Selected))
            {
                result = selectedStyle;
            }
            else
            {
                result = null;
            }
            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
