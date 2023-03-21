using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_01
{
    internal class Student
    {
        private int id;
        private string name;
        private char gender;
        private int age;
        private DateTime dateOfBirth;
        private string className;
        private double mark1, mark2, mark3;

        public int Id
        {
            get => id;
            set => id = value > 0 ? value : throw new ArgumentException("Id must be positive.");
        }
        public string Name
        {
            get => name;
            set => name = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Name must not be empty or null.");
        }
        public char Gender
        {
            get => gender;
            set => gender = (value == 'M' || value == 'F') ? value : throw new ArgumentException("Gender must be 'M' or 'F'.");
        }
        public int Age
        {
            get => age;
            set => age = value >= 0 ? value : throw new ArgumentException("Age must be non-negative.");
        }
        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value <= DateTime.Now ? value : throw new ArgumentException("Date of birth cannot be in the future.");
        }
        public string ClassName
        {
            get => className;
            set => className = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Class name must not be empty or null.");
        }
        public double Mark1
        {
            get => mark1;
            set => mark1 = CheckMark(value);
        }
        public double Mark2
        {
            get => mark2;
            set => mark2 = CheckMark(value);
        }
        public double Mark3
        {
            get => mark3;
            set => mark3 = CheckMark(value);
        }

        public double Mark_AVG() => (mark1 + mark2 + mark3) / 3.0;

        private double CheckMark(double mark)
        {
            if (mark < 0 || mark > 100)
            {
                throw new ArgumentException("Mark must be between 0 and 100.");
            }
            return mark;
        }
    }
}
