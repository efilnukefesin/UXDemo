using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace NET.efilnukefesin.Apps.UXDemo.Converters
{
    public class StyleConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(Style))
            {
                throw new InvalidOperationException("The target must be a Style");
            }

            var styleProperty = parameter as string;
            if (value == null || styleProperty == null)
            {
                return null;
            }

            string styleValue = value.GetType()
                .GetProperty(styleProperty)
                .GetValue(value, null)?
                .ToString();
            if (styleValue == null)
            {
                return null;
            }

            Style newStyle = (Style)Application.Current.TryFindResource(styleValue);
            return newStyle;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            //throw new NotImplementedException();
            return new StyleConverter();
        }
    }
}
