using GradesAverage.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace AverageGrades
{
    public class CoursesListViewModelUi
    {
        public ObservableCollection<CourseItemViewModel> Items { get; set; }

        public CoursesListViewModelUi()
        {
            // { Debug.WriteLine(/*((CourseItemViewModel)s).CourseName + */ " 'Items' is Added/changed."); };

            Items = new ObservableCollection<CourseItemViewModel>()
            {
            //new CourseItemViewModel() { CourseName = "One for me"   ,Mark= 96,Points = 2     ,Year = 2,Semester = eSemester.B},
            //new CourseItemViewModel() { CourseName = "Two for you :)", Mark = 81, Points = 4.5f, Year = 1, Semester = eSemester.A },
            //new CourseItemViewModel() { CourseName = "Third is here ", Mark = 83, Points = 3.5f, Year = 3, Semester = eSemester.A },
            //new CourseItemViewModel() { CourseName = "Fore to see long text input.", Mark = 77, Points = 2f, Year = 2, Semester = eSemester.C },

            };

            Items.CollectionChanged += (s, e) => 
            { Debug.WriteLine((s as ObservableCollection<CourseItemViewModel>)?.Count + " 'Items' is Added/changed."); };

            Items.Add(new CourseItemViewModel() { CourseName = "One for me", Mark = 96, Points = 2, Year = 2, Semester = eSemester.B });
            Items.Add(new CourseItemViewModel() { CourseName = "Two for you :)", Mark = 81, Points = 4.5f, Year = 1, Semester = eSemester.A }            );
            Items.Add(new CourseItemViewModel() { CourseName = "Third is here ", Mark = 83, Points = 3.5f, Year = 3, Semester = eSemester.A }            );
            Items.Add(new CourseItemViewModel() { CourseName = "Fore to see long text input.", Mark = 77, Points = 2f, Year = 2, Semester = eSemester.C });

            //orderByTime();

            //Timer time = new Timer();
            //time.Interval = 4_000;
            ////time.Elapsed += (s, e) => { if (true) { orderByTime22(); } };

            //time.Start();


        }

        private void orderByTime22()
        {
            Debug.WriteLine("In the Func");
            Random rand = new Random();
            int num = rand.Next() % 2;

            Application.Current.Dispatcher.Invoke(() =>
            {
                switch (num)
                {
                    case 0:
                        //Items = new ObservableCollection<CourseItemViewModel>(Items.OrderBy((n1) => -n1.Mark));
                        Items.CollectionChanged += (s, e) => { Debug.WriteLine("Changed from 0"); };
                        break;
                    //case 1:
                    //    Items = new ObservableCollection<CourseItemViewModel>(Items.OrderBy((n1) => n1.CourseName));
                    //    Items.CollectionChanged += (s, e) => { Debug.WriteLine("Changed from 1"); };
                    //    break;
                    //case 2:
                    //    Items = new ObservableCollection<CourseItemViewModel>(Items.OrderByDescending((n1) => n1.Points));
                    //    Items.CollectionChanged += (s, e) => { Debug.WriteLine("Changed from 2"); };
                    //    break;
                    case 1:
                        Items.Add(new CourseItemViewModel() { CourseName = "blank" ,Mark = 90,Points = 2 , Year = 2 , Semester = eSemester.A });
                        break;
                }
            });
        }

        private void orderByTime()
        {
            Debug.WriteLine("In the Func");
            Random rand = new Random();
            int num = rand.Next() % 3;
            
            Application.Current.Dispatcher.Invoke(() =>
            {
                switch (num)
                {
                    case 0:
                        Items.Add(
                        new CourseItemViewModel()
                        {
                            CourseName = " case 0",
                            Mark = 77,
                            Points = 2f,
                            Year = 2,
                            Semester = eSemester.C
                        });

                        break;
                    case 1:
                        Items.Add(
                        new CourseItemViewModel()
                        {
                            CourseName = " case 1",
                            Mark = 77,
                            Points = 2f,
                            Year = 2,
                            Semester = eSemester.C
                        });

                        break;
                    case 2:
                        Items.Add(
                        new CourseItemViewModel()
                        {
                            CourseName = " case 2",
                            Mark = 77,
                            Points = 2f,
                            Year = 2,
                            Semester = eSemester.C
                        });

                        break;
                }
            });
        }
    }
}
