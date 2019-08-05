using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesAverage.Core
{
    public class CoursesListViewModel
    {
        public ObservableCollection<CourseItemViewModel> Items { get; set; }
    }
}
