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

namespace WpfTryStuff1
{
    public class CoursesListViewModelDesignUi : CoursesListViewModel
    {
        private bool active { get; set; } = true;

        public static CoursesListViewModelDesignUi Lists => new CoursesListViewModelDesignUi();

        public CoursesListViewModelDesignUi()
        {
           

           fillData();
        }

        private void fillData()
        {

            Items = new ObservableCollection<CourseItemViewModel>()
            {
            new CourseItemViewModel() { CourseName = ".Net & C#"   ,Mark= 92,Points = 3     ,Year = 2,Semester = eSemester.B},
            new CourseItemViewModel() { CourseName = "Graph theory", Mark = 80, Points = 3.5f, Year = 2, Semester = eSemester.A },
            new CourseItemViewModel() { CourseName = "Linery", Mark = 61, Points = 5, Year = 1, Semester = eSemester.A },
            new CourseItemViewModel() { CourseName = "C++", Mark = 99, Points = 5, Year = 2, Semester = eSemester.A },
            new CourseItemViewModel() { CourseName = "Prog c", Mark = 79, Points = 5, Year = 1, Semester = eSemester.A },
            new CourseItemViewModel() { CourseName = "C pro", Mark = 90, Points = 4f, Year = 1, Semester = eSemester.B },
            new CourseItemViewModel() { CourseName = "Data Structs", Mark = 85, Points = 4f, Year = 1, Semester = eSemester.B },
            new CourseItemViewModel() { CourseName = "Philosopy44", Mark = 50, Points = 2, Year = 1, Semester = eSemester.C },
            new CourseItemViewModel() { CourseName = "Philosopy", Mark = 90, Points = 2, Year = 1, Semester = eSemester.C },
            };

            orderByTime();

            Timer time = new Timer();
            time.Interval = 4_000; 
            time.Elapsed += (s, e) => { if (true) { orderByTime(); } }; 

            time.Start();


        }



        private void orderByTime()
        {
            Debug.WriteLine("In the Func");
            Random rand = new Random();
            int num = rand.Next() % 2;

            Application.Current.Dispatcher.Invoke(() =>
            {

                switch (num)
                {
                    case 0:
                        Items = new ObservableCollection<CourseItemViewModel>(Items.OrderBy((n1) => -n1.Mark));
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
                        Items.Add(new CourseItemViewModel() { CourseName = "blank"});
                        break;
                }
            });
        }

    }
}

