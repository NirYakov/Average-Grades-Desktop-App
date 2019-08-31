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
        public ObservableCollection<CourseItemViewModel> Items { get; private set; }

        public RelayCommand<CourseItemViewModel> AddCourseCommand { get; }

        public RelayCommand<CourseItemViewModel> RemoveCourseCommand { get; }

        public CoursesListViewModel()
        {
            /*AddCourseCommand*/
            AddCourseCommand = new RelayCommand<CourseItemViewModel>(AddMoreOne/* , CheckToAddCourse */);

            RemoveCourseCommand = new RelayCommand<CourseItemViewModel>(RemoveCourse);

            Items = new ObservableCollection<CourseItemViewModel>()
            {
            new CourseItemViewModel() { CourseName = "One for me"   ,  Mark= 96,Points = 2     ,Year = 2,Semester = eSemester.B},
            new CourseItemViewModel() { CourseName = "Two for you :)", Mark = 81, Points = 4.5f, Year = 1, Semester = eSemester.A },
            new CourseItemViewModel() { CourseName = "Third is here ", Mark = 83, Points = 3.5f, Year = 3, Semester = eSemester.A },
            new CourseItemViewModel() { CourseName = "Fore to see long text input.", Mark = 77, Points = 2f, Year = 2, Semester = eSemester.C },
            };

           // try
            {
             //   Items = StaticSaverTest.DataMeneger.LoadData();
                 //StaticSaverTest.DataMeneger.SaveData(Items);
            }
           // catch (Exception ex)
            {

            }


            // Items = new ObservableCollection<CourseItemViewModel>(Items.OrderBy(n => n.Mark));


           // initItemsList();
        }

        private void initItemsList()
        {

            Items = new ObservableCollection<CourseItemViewModel>(Items.OrderBy(n => n.Mark));


            // throw new NotImplementedException();
        }

        private int index = 0;

        public void AddMoreOne(CourseItemViewModel i_ParametersAry)
        {
            if (i_ParametersAry != null)
            {
                Items.Add(i_ParametersAry);
            }

            // StaticSaverTest.DataMeneger.SaveData(Items);

            //Items.Add(new CourseItemViewModel() { CourseName = $"blank --> {index++}" });
        }


        public bool CheckToAddCourse(CourseItemViewModel i_Params)
        {
            // BM : to add condition for the added courses.
            bool canAdd = true;
            if (i_Params != null)
            {
                if (!(0 >= i_Params.Mark && i_Params.Mark <= 100))
                {
                    canAdd = false;
                }

                if (!(0 >= i_Params.Points && i_Params.Points <= 12))
                {
                    canAdd = false;
                }
            }
            else
            {
                canAdd = false;
            }

            return canAdd;
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