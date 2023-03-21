using Exam_01;
using System;

class Program
{
    static void Main(string[] args)
    {
        TestStudent test = new TestStudent();

        bool exit = false;

        do
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Sort students by average mark");
            Console.WriteLine("3. Print all students");
            Console.WriteLine("4. Find student by name");
            Console.WriteLine("5. Remove student by ID");
            Console.WriteLine("6. Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    test.AddStudent();
                    break;
                case "2":
                    test.SortStudentsByMark();
                    break;
                case "3":
                    test.PrintAllStudents();
                    break;
                case "4":
                    test.FindStudentByName();
                    break;
                case "5":
                    test.RemoveStudent();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        } while (!exit);
    }
}
