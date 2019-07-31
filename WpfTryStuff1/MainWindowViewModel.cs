using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtillsCalAvrg;

namespace WpfTryStuff1
{
    public class MainWindowViewModel
    {
        public ObservableCollection<CourseListItem> Items { get; set; }

        public MainWindowViewModel()
        {
            initData();
            //var rawData = TestDataClassUi0.AllData;
            //Items = new ObservableCollection<CourseListItem>(
            //    rawData.Select(data => new CourseListItem()
            //    {
            //        Name = data.CourseName,
            //        Mark = data.Mark,
            //        Points = data.Points,
            //        Year = data.Year,
            //        Semester = data.Semester

            //    }));

        }

        private void initData()
        {
            // var rawData = TestDataClassUi0.AllData;
            //var rawData = TestDataClass.AllData;

            //Items = new ObservableCollection<CourseListItem>(
            //    rawData.Select(data => new CourseListItem()
            //    {
            //        Name = data.CourseName,
            //        Mark = data.Mark,
            //        Points = data.Points,
            //        Year = data.Year,
            //        Semester = data.Semester

            //    }));
        }
    }
}
