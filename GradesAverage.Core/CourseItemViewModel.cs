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
        public string CourseName { get; set; }

        public ushort Mark { get; set; } = 24;

        public float Points { get; set; }

        public short Year { get; set; }

        public eSemester Semester { get; set; }

        public override string ToString()
        {
            return CourseName;
        }
    }

    //public enum eSemester : ushort
    //{
    //    A  = 'A',
    //    B  = 'B',
    //    C = 'C'
    //}
}
