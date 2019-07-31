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

namespace WpfTryStuff1
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
            DataFill1(); 
        }

        private void DataFill1()
        {

        }

        private void DataFill0()
        {
            //List<CourseListItem> items = new List<CourseListItem>();
            //Thickness thick = new Thickness(0);

            //double height = 110, width = 260;

            //items.Add(new CourseListItem() { Margin = thick, Height = height, Width = width });
            //items.Add(new CourseListItem() { Margin = thick,TheMark = "97", Height = height, Width = width });

            //CourseListItem item = new CourseListItem() { Margin = thick, Height = height, Width = width };

            //item.CourseName.Text = "Hello";
            //item.TheMark = "105";
            //item.Points.Text = "4.5";
            //item.Semester.Text = "A";
            //item.Year.Text = "2";

            //items.Add(item);


            //ListCourses.Items.Clear();
            //ListCourses.ItemsSource = items;



            //ListCourses
            //ObservableCollection<CourseListItem> _collection;

            //_collection = new ObservableCollection<CourseListItem>();


            //DataContext = _collection;


            //foreach (CourseListItem var0 in items)
            //{
            //    _collection.Add(var0);
            //}
        }
    }
}
