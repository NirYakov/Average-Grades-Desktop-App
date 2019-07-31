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
using UtillsCalAvrg;

namespace WpfTryStuff1
{
    /// <summary>
    /// Interaction logic for CourseListItem.xaml
    /// </summary>
    public partial class CourseListItem : UserControl
    {
        public CourseListItem()
        {
            InitializeComponent();
        }


        public string CourseName { get { return CourseName0.Text; } set { value = CourseName0.Text; } }

        public ushort Mark { get { return ushort.Parse((Mark0.Text)); } set { Mark0.Text = value.ToString(); } }

        public float Points { get{ return float.Parse((Points0.Text)); } set { Points0.Text = value.ToString(); } }

        public short Year { get { return short.Parse((Year0.Text)); } set { Year0.Text = value.ToString(); } }

        public eSemester Semester { get{ return (eSemester)Enum.Parse(typeof(eSemester),(Semester0.Text)); } set { Semester0.Text = value.ToString(); } } 

        //  public string CName { get { return CName; } set { CName = value; CName; } }
    }
}
