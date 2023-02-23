using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using Kaenx.Creator.Models;

namespace Kaenx.Creator.Converter
{
    public class ComObjectToString : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((ComObject)value).Name + " - " + ((ComObject)value).FunctionText[0].Text;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new Exception("not supported");
        }
    }
}
