using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AverageGrades
{
    public class MainWindowViewModel
    {
        // TODO: fill the view model

        public RelayCommand<object> AddCommand { get; }

        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand<object>(AddCourse);
        }

        int m_Index = 0;

        public void AddCourse(object i_NonUse)
        {
            Application.Current.Dispatcher.Invoke(() =>
           {
               //CoursesListViewModelDesignUi.Lists.Items.Add(
               //CoursesListViewModelDesignUi.Lists.AddMoreOne(
               //    new GradesAverage.Core.CourseItemViewModel()
               //    {
               //        CourseName = $"No. {m_Index}"
               //    });

             //  CoursesListViewModelDesignUi.Lists.AddMoreOne();

               Debug.WriteLine($"in {nameof(AddCommand)} , [{m_Index}]");

               m_Index++;
           }
           );
        }

    }
}
