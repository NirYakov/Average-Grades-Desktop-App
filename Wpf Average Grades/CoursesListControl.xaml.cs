using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using GradesAverage.Core;
using System.Diagnostics;

namespace AverageGrades
{
    /// <summary>
    /// Interaction logic for CoursesListControl.xaml
    /// </summary>
    public partial class CoursesListControl : UserControl
    {
        public CoursesListControl()
        {
            InitializeComponent();
        }

        private void CourseListItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //  Debug.WriteLine($"Clicked [{sender}]");

            CourseListItem item = sender as CourseListItem;
            if (item != null)
            {
                Debug.WriteLine($"Clicked [{item.CourseName0.Text}]");
            }

        }
    }
}
