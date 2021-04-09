using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class Student
    {
        private string city;
        private string firstName;
        private string lastName;
        private string program;
        private string courses;
        private double gpa;
        private int semester;
        private bool isDomestic;

        public string City { get { return city; } private set { city = value; } }
        public string FirstName { get { return firstName; } private set { firstName = value; } }
        public string LastName { get { return lastName; } private set { lastName = value; } }
        public string Program { get { return program; } private set { program = value; } }
        public string Courses { get { return courses; } private set { courses = value; } }
        public double Gpa { get { return gpa; } private set { gpa = value; } }
        public int Semester { get { return semester; } private set { semester = value; } }
        public bool IsDomestic { get { return isDomestic; } private set { isDomestic = value; } }

        public Student(
            string city,
            string firstName,
            string lastName,
            string program,
            string courses,
            double gpa,
            int semester,
            bool isDomestic)
        {
            City = city;
            FirstName = firstName;
            LastName = lastName;
            Program = program;
            Courses = courses;
            Gpa = gpa;
            Semester = semester;
            IsDomestic = isDomestic;
        }
    }
}
