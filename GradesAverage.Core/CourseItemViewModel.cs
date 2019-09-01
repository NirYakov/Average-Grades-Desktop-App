using GradesAverage.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesAverage.Core
{
    public class CourseItemViewModel
    {
        private readonly Course r_Course;

        public CourseItemViewModel()
        {
            r_Course = new Course();
        }

        public string CourseName
        {
            get { return r_Course.CourseName; }
            set { r_Course.CourseName = value; }
        }

        public ushort Mark {
            get { return r_Course.Mark; }
            set { r_Course.Mark = value; }
        }

        public float Points
        {
            get { return r_Course.Points; }
            set { r_Course.Points = value; }
        }

        public short Year {
            get { return r_Course.Year; }
            set { r_Course.Year = value; }
        }

        public eSemester Semester {
            get { return r_Course.Semester; }
            set { r_Course.Semester = value; }
        }

        public float Delta { get => r_Course.DeltaToMaxMarkValue; }

        public override string ToString()
        {
            return r_Course.ToString() ;
        }
    }
}
