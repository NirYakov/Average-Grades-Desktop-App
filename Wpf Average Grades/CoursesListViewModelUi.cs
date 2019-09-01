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
using System.Windows.Data;

namespace AverageGrades
{
    public class CoursesListViewModelUi : CoursesListViewModel 
    {

        public CoursesListViewModelUi()
        {

        }

        public void SomeTesting()
        {
            // Items = new ObservableCollection<CourseItemViewModel>()
            // {
            //    new CourseItemViewModel() { CourseName = "Two for you :)", Mark = 81, Points = 4.5f, Year = 1, Semester = eSemester.A },
            //};

            // try
            {
                //   Items = StaticSaverTest.DataMeneger.LoadData();
                //StaticSaverTest.DataMeneger.SaveData(Items);
            }
            // catch (Exception ex)
            {

            }

            //r_CourseCheck;

            // Items = new ObservableCollection<CourseItemViewModel>(Items.OrderBy(n => n.Mark));


            // initItemsList();
        }

        public void SortListTrys()
        {
            //ListCollectionView list = new ListCollectionView(Items);
            ListCollectionView list = CollectionViewSource.GetDefaultView(Items) as ListCollectionView;

            Items.CollectionChanged += (s, e) =>
            {
                

            };

        }

    }

}
