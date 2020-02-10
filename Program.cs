using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Module3___Self_Assessment_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run the same code in Program.cs from Module One's self assessment lab to create instances of your classes so that you can setup a single course that is part of a program and a degree path. Be sure to include at least one Teacher and an array of Students.
            //Ensure the Console.WriteLine statements you included in Module One's self assessment lab still output the correct information
            //Instantiate a UProgram object called Information Technology.
            var universityProgram = new UProgram("Information Technology");

            //Instantiate a Degree object, such as Bachelor.
            var degree = new Degree("Bachelor");

            //Add the Degree object to the UProgram object.
            universityProgram.Degree = degree;

            //Instantiate a Course object called Programming with C#.
            var course = new Course("Programming with C#");

            //Add your Course object to the Degree object.
            degree.Course = course;

            //Instantiate three Student objects.
            Student student1 = new Student("Alexander Delgado", 19, "San Francisco", "Hispanic");
            Student student2 = new Student("Janet Jackason", 18, "Atlanta", "Black");
            Student student3 = new Student("Natalie Castro", 21, "Los Angeles", "Hispanic");

            var sArray = new Student[3];
            sArray[0] = student1;
            sArray[1] = student2;
            sArray[2] = student3;

            //Add your three students to this Course object.
            course.Students = sArray;

            //Instantiate at least one Teacher object.
            Teacher teacher1 = new Teacher("Amy Shaffer", 38, false, "Seattle", "Unknown");
            Teacher teacher2 = new Teacher("Juan Bonilla", 47, true, "Houston", "Unknown");

            var tArray = new Teacher[2];
            tArray[0] = teacher1;
            tArray[1] = teacher2;

            //Add that Teacher object to your Course object.
            course.Teachers = tArray;

            //Using Console.WriteLine statements, output the following information to the console window:
            //The name of the program and the degree it contains
            //The name of the course in the degree
            //The count of the number of students in the course.
            Console.WriteLine($"The name of the program is {universityProgram.Name} and it contains a {degree.Name} degree.");
            Console.WriteLine($"The name of the course in the {degree.Name} Degree is {course.Name}.");
            Console.WriteLine($"There are {Student.instances} students enrolled in the {course.Name} course.");

            StreamReader teacher = null;
            foreach (var teacher in tArray)
            {
                teacher.WriteData(@"C: \Users\rosem\source\repos\Module3 - Self - Assessment Lab\Module3 - Self - Assessment Lab\bin\Debug/teachers.txt");
                if (teacher != null)
                {
                    teacher.Close();
                    teacher.Dispose();
                }
            }

            foreach (var student in sArray)
            {
                student.WriteData(@"C: \Users\rosem\source\repos\Module3 - Self - Assessment Lab\Module3 - Self - Assessment Lab\bin\Debug/teachers.txt");
                if (student != null)
                {
                    student.Close();
                    student.Dispose();
                }
            }
        }
    }
}
