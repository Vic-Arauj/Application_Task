using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Application_Task.Libraries.Converts
{
    internal class BoolToTextDecorationStrike : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            bool isCompleted = (bool)value;

            return isCompleted ? TextDecorations.Strikethrough : TextDecorations.None;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
