using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_3StuSys
{
    enum Month
    {
        January = 0,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    enum Grade
    {
        A = 0,
        B,
        C,
        D,
        F
    }
    
    class StudentGPAComparar : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return y.GPA.CompareTo(x.GPA);
        }
    }

    class StudentIDComparar : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.StudentID - y.StudentID;
        }
    }

    internal class Student : IComparable<Student> 
    {
        static protected int ID = 1001;

        private int studentID;
        public int StudentID { get { return this.studentID; } }
        public String? First_Name { get; set; }
        public String? Last_Name { get; set; }
        public double GPA { get; set; }
        public Month Month_Of_Admission { get; set; }
        public Grade Grade { get; set; }

        public Student()
        {
            this.studentID = ID++;
            this.First_Name = "";
            this.Last_Name = "";
        }

        public Student(string fname, string lname, double gpa, Month month, Grade grade)
        {
            this.studentID = ID++;
            this.First_Name = fname;
            this.Last_Name = lname;
            this.GPA = gpa;
            this.Month_Of_Admission = month;
            this.Grade = grade;
        }

        public int CompareTo(Student other)
        {
            return this.First_Name.CompareTo(other.First_Name);
        }

        public override string ToString()
        {
            return $"{First_Name} {Last_Name} ({studentID}) - GPA: {GPA} - Grade: {Grade} - Month of admission: {Month_Of_Admission}\n";
        }
    }
}
