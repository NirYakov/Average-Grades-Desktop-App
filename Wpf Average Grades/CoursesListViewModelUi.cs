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

        public RelayCommand UndoCommand { get; }
    
        private readonly Stack<int> r_CoursesStackIndexes;

        public CoursesListViewModelUi()
        {
            //UndoCommand = new RelayCommand(Undo, CanUndo);
            UndoCommand = new RelayCommand(Undo);
            r_CoursesStackIndexes = new Stack<int>();
        }

        public override void AddMoreOne(string[] i_ParametersAry)
        {
            base.AddMoreOne(i_ParametersAry);
            r_CoursesStackIndexes.Push(Items.Count - 1);
        }

        public void Undo()
        {
            if ((r_CoursesStackIndexes.Count > 0))
            {
                CourseItemViewModel item = Items[r_CoursesStackIndexes.Peek()];
                CalAverage.SubstractMarkAndPoints(item.Mark,item.Points);
                Items.RemoveAt(r_CoursesStackIndexes.Pop());
            }
        }

        public bool CanUndo()
        {
            bool canUndo = true;
            if (r_CoursesStackIndexes.Count <= 0)
            {
                canUndo = false;
            }

            return canUndo;
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
