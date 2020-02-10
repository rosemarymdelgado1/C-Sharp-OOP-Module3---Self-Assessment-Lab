using System;
using System.Collections.Generic;
using System.Text;

namespace Module3___Self_Assessment_Lab
{
    //Create a Person base class with common attributes for a person. Remember to use encapsulation for these attributes.
    //Applying proper OOP principles, make Person an abstract class.
    public abstract class Person
    {
        private string _name;
        private string _race_ethnicity;
        private string _cityresidence;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public String Race_Ethnicity
        {
            get { return _race_ethnicity; }
            set { _race_ethnicity = value; }
        }

        public string CityResidence
        {
            get { return _cityresidence; }
            set { _cityresidence = value; }
        }

        public Person(string name, string race_ethnicity, string cityresidence)
        {
            this.Name = name;
            this.Race_Ethnicity = race_ethnicity;
            this.CityResidence = cityresidence;
        }
    }
}
