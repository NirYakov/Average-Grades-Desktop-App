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

        public RelayCommand<string[]> AddCourseCommand { get; }

        public RelayCommand<CourseItemViewModel> RemoveCourseCommand { get; }

        private readonly CourseItemViewModel r_CourseCheck;

        public CalculateAvg CalAverage { get; set; }

        public CoursesListViewModel()
        {
            /*AddCourseCommand*/
            AddCourseCommand = new RelayCommand<string[]>(AddMoreOne, CheckToAddCourse);

            RemoveCourseCommand = new RelayCommand<CourseItemViewModel>(RemoveCourse);

            r_CourseCheck = new CourseItemViewModel();

            CalAverage = new CalculateAvg();

            Items = new ObservableCollection<CourseItemViewModel>();
            

            r_CourseCheck = new CourseItemViewModel() { CourseName = "One for me", Mark = 96, Points = 2, Year = 2, Semester = eSemester.B };
            Items.Add(r_CourseCheck);
            CalAverage.AddMarkAndPoints(r_CourseCheck.Mark , r_CourseCheck.Points);


            r_CourseCheck = new CourseItemViewModel() { CourseName = "Two for you :)", Mark = 81, Points = 4.5f, Year = 1, Semester = eSemester.A };
            Items.Add(r_CourseCheck);
            CalAverage.AddMarkAndPoints(r_CourseCheck.Mark , r_CourseCheck.Points);


            r_CourseCheck = new CourseItemViewModel() { CourseName = "Third is here ", Mark = 83, Points = 3.5f, Year = 3, Semester = eSemester.A };
            Items.Add(r_CourseCheck);
            CalAverage.AddMarkAndPoints(r_CourseCheck.Mark , r_CourseCheck.Points);


            r_CourseCheck = new CourseItemViewModel() { CourseName = "Fore to see long text input.", Mark = 77, Points = 2f, Year = 2, Semester = eSemester.C };
            Items.Add(r_CourseCheck);
            CalAverage.AddMarkAndPoints(r_CourseCheck.Mark , r_CourseCheck.Points);
           

            // try
            {
                //   Items = StaticSaverTest.DataMeneger.LoadData();
                //StaticSaverTest.DataMeneger.SaveData(Items);
            }
            // catch (Exception ex)
            {

            }

        }

        private void initItemsList()
        {

            Items = new ObservableCollection<CourseItemViewModel>(Items.OrderBy(n => n.Mark));


            // throw new NotImplementedException();
        }

        private int index = 0;

        public bool CheckToAddCourse(string[] i_ParametersAry)
        {
            // BM : to add condition for the added courses.
            bool canAdd = true;
            if (i_ParametersAry != null)
            {
                try
                {
                        r_CourseCheck.CourseName = i_ParametersAry[0];
                        r_CourseCheck.Mark = ushort.Parse(i_ParametersAry[1]);
                        r_CourseCheck.Points = float.Parse(i_ParametersAry[2]);
                        r_CourseCheck.Year = short.Parse(i_ParametersAry[3]);
                        r_CourseCheck.Semester = (eSemester)Enum.Parse(typeof(eSemester), i_ParametersAry[4]);
                }
                catch
                {
                    canAdd = false;
                }
            }

            return canAdd;
        }

        public void AddMoreOne(string[] i_ParametersAry)
        {
            if (i_ParametersAry != null)
            {
                Items.Add(new CourseItemViewModel()
                {
                    CourseName = r_CourseCheck.CourseName,
                    Mark = r_CourseCheck.Mark,
                    Points = r_CourseCheck.Points,
                    Year = r_CourseCheck.Year,
                    Semester = r_CourseCheck.Semester
                });

                CalAverage.AddMarkAndPoints(r_CourseCheck.Mark, r_CourseCheck.Points);
            }
            
            // StaticSaverTest.DataMeneger.SaveData(Items);

            //Items.Add(new CourseItemViewModel() { CourseName = $"blank --> {index++}" });
        }

        public void RemoveCourse(CourseItemViewModel i_ToDelete)
        {
            // BM : To remember to delete from the total Average
            Items.Remove(i_ToDelete);
            CalAverage.SubstractMarkAndPoints(i_ToDelete.Mark, i_ToDelete.Points);
        }

        // Dont work , not waste time for now .
        public void SortListDontWork()
        {
            List<CourseItemViewModel> list; // ICollection<CourseItemViewModel>(); // List<CourseItemViewModel>();

            //Items = new ObservableCollection<CourseItemViewModel>(Items.OrderBy(n => n.Mark));

            

        }
    }
}