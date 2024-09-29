using BookStoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace BookStoreManagement.Converters
{
    public class GenresConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var bookGenres = values[0] as List<BookGenre>;
            if (bookGenres != null && bookGenres.Any())
            {
                return string.Join(", ", bookGenres.Select(bg => bg.Genre.GenreName));
            }
            return "Chưa có thể loại";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
