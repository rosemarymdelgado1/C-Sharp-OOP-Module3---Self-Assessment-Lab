using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Module3___Self_Assessment_Lab
{
    //Teacher
    //Make your Student and Teacher classes inherit from the Person base class
    //Modify your Student and Teacher classes so that they inherit the common attributes from Person
    public class Teacher : Person
    {
        private int _age;
        private bool _PhD;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool PhD
        {
            get { return _PhD; }
            set { _PhD = value; }
        }

        public static int instances = 0;

        public Teacher(string name, int age, bool PhD, string cityresidence, string race_ethnicity) : base(name, cityresidence, race_ethnicity)
        {
            this.Age = age;
            this.PhD = PhD;
            instances++;
        }
        //Modify your Student and Teacher classes so they include characteristics specific to their type.For example, a Teacher object might have a GradeTest() method where a student might have a TakeTest() method.
        public static int CountTeacher()
        {
            return instances;
        }
    }
}