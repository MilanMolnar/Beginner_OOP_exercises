using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ObjectMethods
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string Aname, string Amajor, double Agpa)
        {
            name = Aname;
            major = Amajor;
            gpa = Agpa;
        }
        public bool HasHonors()
        {
            if (gpa >= 3.5) 
            {
                return true;
            }
            return false;
        }
    }
}
