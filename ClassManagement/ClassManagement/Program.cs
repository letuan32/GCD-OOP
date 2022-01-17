using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassManagement
{
    internal class Program
    {
        private static List<Student> students = new List<Student>();
        private static List<Teacher> teachers = new List<Teacher>();

        private static void Main(string[] args)
        {
            Program program = new Program();

            int option;
            bool isClose = false;
            while (isClose == false)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1-Xem danh sach sinh vien");
                Console.WriteLine("2-Them sinh vien");
                Console.WriteLine("3-Tim sinh vien bang MSSV");
                Console.WriteLine("4-Tim sinh vien bang ten");
                Console.WriteLine("5-Xoa sinh vien");
                Console.WriteLine("0-Thoat chuong trinh");
                Console.Write("Nhap lua chon: ");
                Console.WriteLine("-------------------------------");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        Console.WriteLine("Danh sach sinh vien");
                        program.DisplayAllStudent();
                        break;

                    case 2:
                        Console.Write("So luong sinh vien can them");
                        var numbers = program.GetNumber();
                        Console.WriteLine("Nhap thong tin sinh vien");

                        program.AddStudents(numbers);
                        break;

                    case 3:
                        Console.Write("Nhap MSSV can tim: ");
                        string id = Console.ReadLine();
                        var student = program.GetStudentById(id);
                        if (student != null)
                        {
                            student.DisplayBasicInformation();
                        }
                        else
                        {
                            Console.WriteLine($"Khong tim thay sinh vien voi ma so: {id}");
                        }

                        break;

                    case 4:
                        Console.Write("Nhap ten can tim kiem:");
                        string name = Console.ReadLine();
                        List<Student> result = program.GetStudentByName(name);
                        foreach (var st in result)
                        {
                            st.DisplayBasicInformation();
                        }
                        break;

                    case 5:
                        Console.WriteLine("Chuc nang 5"); break;
                    case 0:
                        isClose = true; break;
                }
            }

            //
        }

        private void DisplayAllStudent()
        {
            if (students.Count > 0)
            {
                foreach (var student in students)
                {
                    student.DisplayBasicInformation();
                }
            }
            else
            {
                Console.WriteLine("Chua co sinh vien");
                Console.WriteLine("Chua co sinh vien");
            }
        }

        private void AddStudents(int numbersOfStudent)
        {
            var student = new Student();
            for (int i = 1; i <= numbersOfStudent; i++)
            {
                Console.WriteLine($"Sinh viên thứ {i}");
                Console.Write("Nhap MSSV:");
                student.Id = Console.ReadLine();
                Console.Write("Nhap ten:");
                student.Name = Console.ReadLine();
                Console.Write("Nhap tuoi: ");
                student.Age = int.Parse(Console.ReadLine());
                Console.Write("Nhap Email: ");
                student.Email = Console.ReadLine();
                Console.Write("Nhap SDT ");
                student.PhoneNumber = Console.ReadLine();
                Console.Write("Nhap lop: ");
                student.Class = Console.ReadLine();
                Console.Write("Nhap chuyen nganh: ");
                student.Major = Console.ReadLine();
                students.Add(student);
                Console.WriteLine("--------------------");
            }
        }

        private int GetNumber()
        {
            var number = int.Parse(Console.ReadLine());
            return number;
        }

        private Student GetStudentById(string id)
        {
            // Dugn vop lap
            //foreach (var student in students)
            //{
            //    if (student.Id == id)
            //    {
            //        return student;
            //    }
            //}
            //return null;

            // Dung ham dung san cua List
            var student = students.Find(x => x.Id.ToLower() == id.ToLower());
            return student;
        }

        private List<Student> GetStudentByName(string name)
        {
            var result = new List<Student>();
            // Cach 1: Vong for
            //foreach (var student in students)
            //{
            //    if (student.Name.ToLower().Contains(name.ToLower()))
            //    {
            //        result.Add(student);
            //    }
            //}
            //return result;
            // Cach 2: DUng ham dung san

            result = students.FindAll(students => students.Name.ToLower().Contains(name.ToLower()));

            // Cach 3: Linq
            var linqResult = students.Where(x => x.Name.ToLower().Contains(name.ToLower()));
            return linqResult.ToList();
        }
    }
}