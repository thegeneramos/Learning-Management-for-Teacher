using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._2
{
    //class StudentGPAComparer : IComparer<Student>
    //{
    //    public int Compare(Student x, Student y)
    //    {
    //        return y.GPA.CompareTo(x.GPA);
    //    }
    //}
    internal struct Student : IComparer<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public int Compare(Student x, Student y)
        {

            return y.GPA.CompareTo(x.GPA);
        }
        //public struct NFloat : IComparable<Student>
        //{

        //}
    }
    internal class GPAComparison : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.GPA.CompareTo(x.GPA);
        }
    }
}