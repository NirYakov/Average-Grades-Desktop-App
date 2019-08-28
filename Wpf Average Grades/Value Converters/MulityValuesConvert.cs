using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using GradesAverage.Core;

namespace AverageGrades
{
    public class MulityValuesConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            CourseItemViewModel item = new CourseItemViewModel();

            try
            {
                item.CourseName = (string)(values[0]);

                if (ushort.TryParse((string)values[1], out ushort mark))
                {
                item.Mark = mark;
                }

                if (float.TryParse((string)values[2], out float points))
                {
                    item.Points = points;
                }

                if (short.TryParse((string)values[3], out short year))
                {
                item.Year = year;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("exception Mulit Val");
            }

            return item;
            //item.CourseName = System.Convert.ToString(values[4]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
