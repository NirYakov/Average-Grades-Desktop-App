using System;
using System.Collections.Generic;
using System.Text;

namespace GradesAverage.Core
{
    public class Course
    {
        private const string k_NotAvailable = "N/a";
        public const float MaxPoints = 12;
        public const ushort MaxMark = 100;

        public string m_CourseName = k_NotAvailable;
        public string CourseName
        {
            get => m_CourseName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    m_CourseName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{ nameof(CourseName) } ,can't be null or whitespace");
                }
            }
        }

        private ushort m_Mark = 200;
        public ushort Mark
        {
            get => m_Mark; //{ return Mark; }
            set
            {
                if (value >= 0 && value <= MaxMark)
                {
                    m_Mark = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Mark)} , range 0 - {MaxMark}");
                }
            }
        }

        private float m_Points = 0;
        public float Points
        {
            get { return m_Points; }
            set
            {
                if (value >= 0 && value <= MaxPoints)
                {
                    m_Points = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Points)} , range 0 - {MaxPoints}");
                }
            }
        }

        private short m_Year = 0;
        public short Year
        {
            get { return m_Year; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    m_Year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Year)} , range 1 - 12");
                }
            }
        }

        public eSemester Semester { get; set; } = eSemester.A;

        public float DeltaToMaxMarkValue
        {
            get
            {
                float deltaInMark = MaxMark - Mark;
                float deltaValue = deltaInMark * m_Points;
                return deltaValue;
            }
        }

        public Course()
        {
        }

        public override string ToString()
        {
            return string.Format("Course name -> {0,-17} , Mark -> {1,3} , Points -> {2,4} , Year -> {3,2} , Semester -> {4,1}",
                CourseName, Mark, Points, Year, Semester);
        }
    }

}

#region Do some problems and throw Ex when try to init

//public string m_CourseName = k_NotAvailable;
//public string CourseName
//{
//    get => m_CourseName;
//    set
//    {
//        if (string.IsNullOrWhiteSpace(value))
//        {
//            m_CourseName = value;
//        }
//        else
//        {
//            // $"{nameof(CourseName)} ,null or whitespace"



//            throw new ArgumentOutOfRangeException();

//            m_CourseName = k_NotAvailable;

//        }
//    }
//}

#endregion
