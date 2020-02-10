using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Module3___Self_Assessment_Lab
{
    //Student
    //Make your Student and Teacher classes inherit from the Person base class
    //Modify your Student and Teacher classes so that they inherit the common attributes from Person
    public class Student : Person
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public static int instances = 0;
        public Student(string name, int age, string cityresidence, string race_ethnicity) : base(name, race_ethnicity, cityresidence)
        {
            this.Name = name;
            instances++;
        }
        public static int CountStudents()
        {
            return instances;
        }
    }
}
