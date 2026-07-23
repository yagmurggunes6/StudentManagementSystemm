using System.IO;
using System.Linq;
using System;
using System.Diagnostics.Tracing;
using System.Runtime.Serialization;


namespace StudentManagementSystem
{
    using System.Xml.Serialization;

    namespace ConsoleApp23
    {

        class Student
        {
            public string FullName { get; set; }
            public int StudentNumber { get; set; }
            public Student(string name, int studentNumber)
            {
                this.FullName = name;
                this.StudentNumber = studentNumber;
            }
        }
        class StudentManager
        {
            private List<Student> students = new List<Student>();
            public void AddStudent()
            {
                Console.Write("Enter your name:");
                string FullName = Console.ReadLine();
                if (string.IsNullOrEmpty(FullName))
                {
                    Console.WriteLine(" Student name cannot be empty.");
                    return;
                }
                Console.Write("Enter your student number:");
                int studentNumber = int.Parse(Console.ReadLine());
                if (studentNumber <= 0)
                {
                    Console.WriteLine("Student number cannot be 0 or negative number.");

                }
                else if (students.Any(s => s.StudentNumber == studentNumber))
                {
                    Console.WriteLine("This student number already exists.");
                    return;
                }
                Student student = new Student(FullName, studentNumber);
                students.Add(student);
                Console.WriteLine("Student added succesfully.");

            }
            public void ListStudents()
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("There are no students in the system.");
                    return;
                }
                foreach (Student student in students)
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine($"Name :{student.FullName}");
                    Console.WriteLine($" Student Number:{student.StudentNumber}");
                }
                Console.WriteLine("------------------");
            }
            public void SearchStudent()
            {
                Console.Write(" Enter student number :");
                int stdnumber = int.Parse(Console.ReadLine());
                Student foundStudent = students.FirstOrDefault(s => s.StudentNumber == stdnumber);
                if (foundStudent == null)
                {
                    Console.WriteLine("Student not foun.");

                }
                else
                {
                    Console.WriteLine($"Student Name : {foundStudent.FullName}");
                    Console.WriteLine($"Student Number : {foundStudent.StudentNumber}");
                }

            }
            public void DeleteStudent()
            {
                Console.Write(" Enter student number:");
                int stdnumber = int.Parse(Console.ReadLine());
                Student foundStudent = students.FirstOrDefault(s => s.StudentNumber == stdnumber);
                if (foundStudent == null)
                {
                    Console.WriteLine("Student not found .");
                    return;
                }
                else
                {
                    students.Remove(foundStudent);
                    Console.WriteLine("Student deleted successfully.");
                }
            }

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                StudentManager manager = new StudentManager();

                while (true)
                {
                    Console.WriteLine("===== Student Management System =====");
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. List Students");
                    Console.WriteLine("3. Search Student");
                    Console.WriteLine("4. Delete Student");
                    Console.WriteLine("5. Exit");

                    Console.Write("Choose an option: ");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            manager.AddStudent();
                            break;

                        case 2:
                            manager.ListStudents();
                            break;

                        case 3:
                            manager.SearchStudent();
                            break;

                        case 4:
                            manager.DeleteStudent();
                            break;

                        case 5:
                            return;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }
        }
    }




}












