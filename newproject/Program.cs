using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                FirstName = "Sara",
                LastName = "Mohammed",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 33, Name = "UML" }
                }
            },
            new Student()
            {
                Id = 7,
                FirstName = "Mohamed",
                LastName = "Abdelstar",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "System Design" },
                    new Subject() { Code = 12, Name = "Aviation" }
                }
            },
            new Student()
            {
                Id = 2,
                FirstName = "Mona",
                LastName = "Gala",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 34, Name = "XML" },
                    new Subject() { Code = 25, Name = "JS" }
                }
            },
            new Student()
            {
                Id = 3,
                FirstName = "Yara",
                LastName = "Yousf",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 25, Name = "JS" }
                }
            },
            new Student()
            {
                Id = 4,
                FirstName = "Ali",
                LastName = "Ali",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 33, Name = "UML" }
                }
            },
            new Student()

            {
                Id = 5,
                FirstName = "Ali",
                LastName = "Ahmed",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 33, Name = "UML" }
                }
            }





        };


        // var filteredName = students.Where(n => n.FirstName == "Ali");
        // foreach (var student in filteredName)
        // {
        //     Console.WriteLine($"{student.FirstName} {student.LastName}");
        // }


        var subject22 = students.Where(s => s.Subjects.Any(sub =>sub.Code ==22));
        foreach (var student in subject22)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
    }
}

class Subject
{
    public int Code { get; set; }
    public string Name { get; set; }
}

class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Subject[] Subjects { get; set; }
}
