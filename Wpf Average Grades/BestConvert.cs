using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace AverageGrades
{
    public class BestConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ushort mark = ushort.Parse((string)value);
            SolidColorBrush color = new SolidColorBrush(Colors.Red);

            if (mark >= 90)
            {
                color.Color = Colors.Green;
            }
            else if (mark >= 80)
            {
                color.Color = Colors.Goldenrod;
            }

            return color;

            //if(value.ToString().Length == 3)
            //   return new SolidColorBrush(Colors.Gray);
            //else  
            //   return new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
