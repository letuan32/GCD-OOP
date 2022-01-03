using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get;set; }
        public double Grade { get; set; }
        public string Status { get;set;}

        public void GetInfor()
        {

            Console.WriteLine("Ma so sinh vien: " + Id);
            Console.WriteLine("Ho ten: " + Name);

            Console.WriteLine("Tuoi: " + Age);

            Console.WriteLine("Chuyen nganh: " + Major);
            Console.WriteLine("Diem trung binh: " + Grade);
            Console.WriteLine("Trang thai: " + Status);
        } 
    }
}
