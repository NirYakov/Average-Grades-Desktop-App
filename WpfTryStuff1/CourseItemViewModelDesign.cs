using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTryStuff1
{
    public class CourseItemViewModelDesign : CourseItemViewModel
    {
        public static CourseItemViewModelDesign Instance => new CourseItemViewModelDesign();

        public CourseItemViewModelDesign()
        {
            CourseName = "Best Of All";
            Mark = 87;
            Points = 4.5f;
            Year = 3;
            Semester = UtillsCalAvrg.eSemester.B;
        }
    }
}
