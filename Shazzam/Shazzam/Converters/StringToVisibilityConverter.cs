﻿using System;
using System.Windows;
using System.Windows.Data;

namespace Shazzam.Converters
{
    internal class StringToVisibilityConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            String temp = value.ToString();
            if (temp.Length == 0)
            {
                return Visibility.Collapsed;

            }
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
