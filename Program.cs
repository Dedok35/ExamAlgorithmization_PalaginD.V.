using System;
using System.Collections.Generic;

namespace Palagin
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.SetStudent("Палагин", "ИС-21", "2023");
            student.Print(student);
            student.GenerateMarks();
            student.PrintMarks();

            var student2 = new Student();
            student2.SetStudent("Садретдинов", "ИС-21", "2023");
            student2.Print(student2);
            student2.GenerateMarks();
            student2.PrintMarks();
            var group = new Group();
            group.SetGroup("Ис-21");
            group.AddStudents(student);
            group.AddStudents(student2);
            group.PrintAllStudINGoup(group);
        }

    }
    class Student
    {
        public List<object> marks = new List<object> { };
        public List<object> dateMarks = new List<object> { };
        public List<object> randomMaks = new List<object> { "б", "п", "н", 2, 3, 4, 5 };
        public string fio;
        public string year_of_admission;
        public string group;

        public void SetStudent(string name, string year_of_admission, string group)
        {

            this.fio = name;
            this.group = group;
            this.year_of_admission = year_of_admission;



        }
        public void Print(Student student)
        {
            Console.WriteLine(student.fio);
            Console.WriteLine(student.year_of_admission);
            Console.WriteLine(student.group);
        }
        public void GenerateMarks()
        {
            Random random = new Random();
            for (int i = 0; i < 11; i++)
            {
                this.marks.Add(this.randomMaks[random.Next(this.randomMaks.Count)]);
                this.dateMarks.Add(DateTime.Now.AddDays(i).Date);

            }
        }
        public void PrintMarks()
        {
            for (int j = 0; j < this.marks.Count; j++)
            {
                Console.WriteLine($"Оценка ученика {this.fio} :{this.marks[j]} || {this.dateMarks[j]}");
            }
        }

    }
    class Group
    {
        public string name;
        public List<Student> students = new List<Student> { };

        public void SetGroup(string name)
        {
            this.name = name;
        }

        public void AddStudents(Student student)
        {
            this.students.Add(student);
        }

        public void PrintAllStudINGoup(Group group)
        {
            for (int a = 0; a < group.students.Count; a++)
            {
                Console.WriteLine($"Группа {group.name} Студент {group.students[a].fio}");
            }
        }
    }
}
