using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesAverage.Core
{
    public class CoursesListViewModel
    {
        public ObservableCollection<CourseItemViewModel> Items { get; set; }

        public RelayCommand<CourseItemViewModel> AddCourseCommand { get; }

        public RelayCommand<CourseItemViewModel> RemoveCourseCommand { get; }

        public CoursesListViewModel()
        {
            /*AddCourseCommand*/
            AddCourseCommand = new RelayCommand<CourseItemViewModel>(AddMoreOne);
            RemoveCourseCommand = new RelayCommand<CourseItemViewModel>(RemoveCourse);

            Items = new ObservableCollection<CourseItemViewModel>()
            {
            new CourseItemViewModel() { CourseName = "One for me"   ,  Mark= 96,Points = 2     ,Year = 2,Semester = eSemester.B},
            new CourseItemViewModel() { CourseName = "Two for you :)", Mark = 81, Points = 4.5f, Year = 1, Semester = eSemester.A },
            new CourseItemViewModel() { CourseName = "Third is here ", Mark = 83, Points = 3.5f, Year = 3, Semester = eSemester.A },
            new CourseItemViewModel() { CourseName = "Fore to see long text input.", Mark = 77, Points = 2f, Year = 2, Semester = eSemester.C },
            };
        }


        private int index = 0;

        public void AddMoreOne(CourseItemViewModel i_ParametersAry)
        {
            if (i_ParametersAry != null)
            {
                Items.Add(i_ParametersAry);
            }

            Items.Add(new CourseItemViewModel() { CourseName = $"blank --> {index++}" });
        }


        public bool CheckToAddCourse(CourseItemViewModel i_Params)
        {
            // BM : to add condition for the added courses.

            throw new NotImplementedException();
        }

        public void RemoveCourse(CourseItemViewModel i_ToDelete)
        {
            // BM : To remember to delete from the total Average
            Items.Remove(i_ToDelete);
        }

// Dont work , not waste time for now .
        public void SortListDontWork()
        {
            List<CourseItemViewModel> list; // ICollection<CourseItemViewModel>(); // List<CourseItemViewModel>();

            //Items = new ObservableCollection<CourseItemViewModel>(Items.OrderBy(n => n.Mark));


        }
    }
}
