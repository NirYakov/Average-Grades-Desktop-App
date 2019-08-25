using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AverageGrades
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            // DataFill1();
            // DataFill0();
        }

        private void DataFill1()
        {
            //var rawData = TestDataClassUi0.AllData;
            //var Items = new ObservableCollection<CourseListItem>();

            //// ListCourses. = Items;
            //ListCourses.Items = Items;
            //ListCourses.Items.Clear();
            //ListCourses.ItemsSource = items;

            //ListCourses.


        }

        private void DataFill0()
        {
            List<CourseListItem> items = new List<CourseListItem>();
            Thickness thick = new Thickness(0);

            items.Add(new CourseListItem());
            items.Add(new CourseListItem());

            items.Add(new CourseListItem());
            items.Add(new CourseListItem());

            items.Add(new CourseListItem());
            items.Add(new CourseListItem());

            items.Add(new CourseListItem());
            items.Add(new CourseListItem());

            items.Add(new CourseListItem());
            items.Add(new CourseListItem());

            CourseListItem item = new CourseListItem();


            items.Add(item);


           // ListCourses.Items.Clear();
           // ListCourses.ItemsSource = items;



            // ListCourses
            ObservableCollection<CourseListItem> _collection;

            _collection = new ObservableCollection<CourseListItem>();


            DataContext = _collection;

            int index = 0;

            foreach (CourseListItem var0 in items)
            {
                var0.CourseName0.Text = $"{index + 10}";
                var0.Points0.Text = $"{index + 2.5}";
                var0.Mark0.Text = $"{index * 10 }";
                index++;
                _collection.Add(var0);
            }
        }
    }
}
