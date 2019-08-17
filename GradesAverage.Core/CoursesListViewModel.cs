using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesAverage.Core
{
    public class CoursesListViewModel
    {
        public ObservableCollection<CourseItemViewModel> Items { get; set; }

        public CoursesListViewModel()
        {
            Items = new ObservableCollection<CourseItemViewModel>()
            {
            new CourseItemViewModel() { CourseName = "One for me"   ,Mark= 96,Points = 2     ,Year = 2,Semester = eSemester.B},
            new CourseItemViewModel() { CourseName = "Two for you :)", Mark = 81, Points = 4.5f, Year = 1, Semester = eSemester.A },
            new CourseItemViewModel() { CourseName = "Third is here ", Mark = 83, Points = 3.5f, Year = 3, Semester = eSemester.A },
            new CourseItemViewModel() { CourseName = "Fore to see long text input.", Mark = 77, Points = 2f, Year = 2, Semester = eSemester.C },

            };
        }
    }
}
