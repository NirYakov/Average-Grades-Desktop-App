using GradesAverage.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesAverage.Core
{
    public class CoursesListViewModelDesign : CoursesListViewModel
    {
        public static CoursesListViewModelDesign Lists => new CoursesListViewModelDesign();


        public CoursesListViewModelDesign()
        {
           

           fillData();
        }

        private void fillData()
        {

            //Items = new ObservableCollection<CourseItemViewModel>()
            //{
            //new CourseItemViewModel() { CourseName = ".Net & C#"   ,Mark= 92,Points = 3     ,Year = 2,Semester = eSemester.B},
            //new CourseItemViewModel() { CourseName = "Graph theory", Mark = 80, Points = 3.5f, Year = 2, Semester = eSemester.A },
            //new CourseItemViewModel() { CourseName = "Linery", Mark = 61, Points = 5, Year = 1, Semester = eSemester.A },
            //new CourseItemViewModel() { CourseName = "C++", Mark = 999, Points = 5, Year = 2, Semester = eSemester.A },
            //new CourseItemViewModel() { CourseName = "Prog c", Mark = 79, Points = 5, Year = 1, Semester = eSemester.A },
            //new CourseItemViewModel() { CourseName = "C pro", Mark = 90, Points = 4f, Year = 1, Semester = eSemester.B },
            //new CourseItemViewModel() { CourseName = "Data Structs", Mark = 85, Points = 4f, Year = 1, Semester = eSemester.B },
            //new CourseItemViewModel() { CourseName = "Philosopy44", Mark = 50, Points = 2, Year = 1, Semester = eSemester.C },
            //new CourseItemViewModel() { CourseName = "Philosopy", Mark = 90, Points = 2, Year = 1, Semester = eSemester.C },
            //};

            //Items = new ObservableCollection<CourseItemViewModel>( Items.OrderBy((n1) => -n1.Mark));

        }


    }
}

