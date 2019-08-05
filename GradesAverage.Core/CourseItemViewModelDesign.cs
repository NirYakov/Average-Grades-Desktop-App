using GradesAverage.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesAverage.Core
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
            Semester = eSemester.B;
        }
    }
}
