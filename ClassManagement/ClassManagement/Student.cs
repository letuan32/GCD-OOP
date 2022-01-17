using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagement
{
    internal class Student : Member
    {
        public string Id { get; set; }
        public string Class { get; set; }
        public string Major { get; set; }
        public double Assignment { get; set; }
        public double MidTerm { get; set; }
        public double Final { get; set; }

        public double Overall
        {
            get
            {
                var overall = (Assignment + MidTerm * 2 + Final * 3) / 6;
                return overall;
            }
        }

        public new void DisplayBasicInformation()
        {
            base.DisplayBasicInformation();
            Console.WriteLine("MSSV: " + Id);
            Console.WriteLine("Lop: " + Class);
            Console.WriteLine("Chuyen nganh: " + Major);
            Console.WriteLine("Overall: " + Overall);
        }

        public void DisplayDetailGrade()
        {
            Console.WriteLine("Bai tap: " + Assignment);
            Console.WriteLine("Giua ki: " + MidTerm);
            Console.WriteLine("Cuoi ki: " + Final);
            Console.WriteLine("Trung binh: " + Overall);
        }
    }
}