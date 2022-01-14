using System;
using System.Collections.Generic;

namespace ClassManagement
{
    internal class Program
    {
        private static List<Student> students = new List<Student>();
        private static List<Teacher> teachers = new List<Teacher>();

        private static void Main(string[] args)
        {
            var studentA = new Student()
            {
                Name = "Le Tuan",
                Age = 20,
                Email = "letuan@gmail.com",
                Class = "GCD191064",
                Major = "IT",
                PhoneNumber = "012",
                Assignment = 5,
                Final = 5,
                MidTerm = 5
            };
            var studentB = new Student()
            {
                Name = "Le Tuan Fake",
                Age = 20,
                Email = "letuan@gmail.com Fake",
                Class = "GCD191064 Fake",
                Major = "IT Fake",
                PhoneNumber = "012 Fake",
                Assignment = 0,
                Final = 1,
                MidTerm = 2
            };
            students.Add(studentA);
            students.Add(studentB);

            Console.WriteLine("Thong tin co ban cua sinh vien");
            if (students.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien o lop nay");
                Console.WriteLine("Khong co sinh vien o lop nay");
                Console.WriteLine("Khong co sinh vien o lop nay");
            }
            else
            {
                foreach (var student in students)
                {
                    student.DisplayBasicInformation();
                    Console.WriteLine("-------------------------------");
                }
            }

            //students.ForEach(student =>
            //{
            //    student.DisplayBasicInformation();
            //    Console.WriteLine("-------------------------------");
            //});
        }
    }
}