using Exam_01;
using System;
using System.Collections.Generic;
using System.Linq;

class TestStudent
{
    private List<Student> students = new List<Student>();

    public void AddStudent()
    {
        Student student = new Student();

        Console.Write("Enter ID: ");
        student.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter Gender ('M' or 'F'): ");
        student.Gender = char.Parse(Console.ReadLine());

        Console.Write("Enter Age: ");
        student.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter Date of birth (dd/MM/yyyy): ");
        student.DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Enter Class name: ");
        student.ClassName = Console.ReadLine();

        Console.Write("Enter Mark 1: ");
        student.Mark1 = double.Parse(Console.ReadLine());

        Console.Write("Enter Mark 2: ");
        student.Mark2 = double.Parse(Console.ReadLine());

        Console.Write("Enter Mark 3: ");
        student.Mark3 = double.Parse(Console.ReadLine());

        students.Add(student);
    }

    public void FindStudentByName()
    {
        Console.Write("Enter name to search: ");
        string name = Console.ReadLine();

        foreach (Student student in students)
        {
            if (student.Name == name)
            {
                Console.WriteLine("Found student:");
                PrintStudent(student);
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    public void EditStudent()
    {
        Console.Write("Enter ID of student to edit: ");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == id)
            {
                Console.WriteLine("Editing student:");
                PrintStudent(students[i]);

                Console.Write("Enter new Name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Enter new Gender ('M' or 'F'): ");
                students[i].Gender = char.Parse(Console.ReadLine());

                Console.Write("Enter new Age: ");
                students[i].Age = int.Parse(Console.ReadLine());

                Console.Write("Enter new Date of birth (dd/MM/yyyy): ");
                students[i].DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.Write("Enter new Class name: ");
                students[i].ClassName = Console.ReadLine();

                Console.Write("Enter new Mark 1: ");
                students[i].Mark1 = double.Parse(Console.ReadLine());

                Console.Write("Enter new Mark 2: ");
                students[i].Mark2 = double.Parse(Console.ReadLine());

                Console.Write("Enter new Mark 3: ");
                students[i].Mark3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Student edited.");
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    public void RemoveStudent()
    {
        Console.Write("Enter ID of student to remove: ");
        int id = int.Parse(Console.ReadLine());

        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == id)
            {
                students.RemoveAt(i);
                Console.WriteLine("Student removed.");
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    public void SortStudentsByMark()
    {
        students.Sort((s1, s2) => s1.Mark_AVG().CompareTo(s2.Mark_AVG()));

        Console.WriteLine("Students sorted by average mark:");
        foreach (Student student in students)
        {
            PrintStudent(student);
        }
    }

    private void PrintStudent(Student student)
    {
        Console.WriteLine($"ID: {student.Id}");
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Gender: {student.Gender}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"Date of birth: {student.DateOfBirth:dd/MM/yyyy}");
        Console.WriteLine($"Class: {student.ClassName}");
        Console.WriteLine($"Mark 1: {student.Mark1}");
        Console.WriteLine($"Mark 2: {student.Mark2}");
        Console.WriteLine($"Mark 3: {student.Mark3}");
        Console.WriteLine($"Average mark: {student.Mark_AVG():F2}");
    }

    public void PrintAllStudents()
    {
        //Console.WriteLine("List of students:");
        //foreach (var student in students)
        //{
        //    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Gender: {student.Gender}, Age: {student.Age}, Date of Birth: {student.DateOfBirth}, Class: {student.ClassName}, Average Mark: {student.Mark_AVG()}");
        //}

        Console.WriteLine("{0,-5} | {1,-20} | {2,-10} | {3,-10} | {4,-15} | {5,-10} | {6,-10} | {7,-10} | {8,-10} | {9,-10}", "Id", "Name", "Gender", "Age", "Date of birth", "Class", "Mark1", "Mark2", "Mark3", "Mark_AVG");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        foreach (var student in this.students)
        {
            Console.WriteLine("{0,-5} | {1,-20} | {2,-10} | {3,-10} | {4,-15:d/M/yyyy} | {5,-10} | {6,-10} | {7,-10} | {8,-10} | {9,-10:F2}",
                student.Id, student.Name, student.Gender, student.Age, student.DateOfBirth, student.ClassName, student.Mark1, student.Mark2, student.Mark3, student.Mark_AVG());
        }
    }
}