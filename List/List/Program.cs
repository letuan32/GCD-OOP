using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            var studentA = new Student()
            {
                Name = "Le Tuan",
                Age = 21,
                Grade = 5.0,
                Status = "Passed",
                Id = "GCD191064",
                Major = "IT"
            };
            var studentB = new Student()
            {
                Name = "Dat",
                Age = 20,
                Grade = 7.0,
                Status = "Passed",
                Id = "GCD191065",
                Major = "IT"
            };
            var studentC = new Student()
            {
                Name = "Tuan fake",
                Age = 20,
                Grade = 3.0,
                Status = "Passed",
                Id = "GCD191064",
                Major = "IT"
            };

            var listStudents = new List<Student>()
            { studentA,studentC};

            students.AddRange(listStudents);

            Console.WriteLine("\n\nSau khi sort");

            students.Sort(x=>x.Grade);

            Console.WriteLine("List ban dau");
            foreach (var student in students)
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Ten: " + student.Name);
                Console.WriteLine("Tuoi: " + student.Age);
                Console.WriteLine("Diem trung binh: " + student.Grade);
                Console.WriteLine("Trang thai: " + student.Status);
                Console.WriteLine("----------------");
            }
            students.Insert(1, studentC);





            //students.Remove(studentA);
            //students.RemoveAt(0);

            // Tìm kiếm
            //var result = students.FindAll(x => x.Id == "GCD191064");
            //Console.WriteLine("Cac phan tu tim duoc");
            //foreach (var student in result)
            //{
            //    Console.WriteLine("Id: " + student.Id);
            //    Console.WriteLine("Ten: " + student.Name);
            //    Console.WriteLine("Tuoi: " + student.Age);
            //    Console.WriteLine("Diem trung binh: " + student.Grade);
            //    Console.WriteLine("Trang thai: " + student.Status);
            //    Console.WriteLine("----------------");
            //}

            //Console.WriteLine("Sau khi chen");
            //students.ForEach(student =>
            //{
            //    Console.WriteLine("Id: " + student.Id);
            //    Console.WriteLine("Ten: " + student.Name);
            //    Console.WriteLine("Tuoi: " + student.Age);
            //    Console.WriteLine("Diem trung binh: " + student.Grade);
            //    Console.WriteLine("Trang thai: " + student.Status);
            //});

            //students.RemoveRange(0, 2);
            //Console.WriteLine("Sau khi xoa");
            //students.ForEach(student =>
            //{
            //    Console.WriteLine("Id: " + student.Id);
            //    Console.WriteLine("Ten: " + student.Name);
            //    Console.WriteLine("Tuoi: " + student.Age);
            //    Console.WriteLine("Diem trung binh: " + student.Grade);
            //    Console.WriteLine("Trang thai: " + student.Status);
            //});

            Console.ReadKey();
        }
    }
}