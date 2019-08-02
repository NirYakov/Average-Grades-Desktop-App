using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTryStuff1
{
    public class CoursesListViewModel
    {
        public ObservableCollection<CourseItemViewModel> Items { get; set; }
    }
}
