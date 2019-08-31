using SaveLoadData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GradesAverage.Core
{
    public static class StaticSaverTest
    {
        //private static readonly ISaveLoadData<CoursesListViewModel> sr_DataMeneger;

        public static ISaveLoadData<ObservableCollection<CourseItemViewModel>> DataMeneger
        {
            get;
            //get { return sr_DataMeneger; }
        }

        static StaticSaverTest()
        {
            DataMeneger = new SaveLoadDataXml<ObservableCollection<CourseItemViewModel>>() { Path = "CourseListData" };
        }
    }
}
