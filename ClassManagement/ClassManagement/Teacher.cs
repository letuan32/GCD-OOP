using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagement
{
    internal class Teacher : Member
    {
        public string Certificate { get; set; }
        public double Salary { get; set; }
        public List<string> Classes { get; set; }

        public new void DisplayBasicInformation()
        {
            base.DisplayBasicInformation();
            Console.WriteLine("Loai bang: " + Certificate);
            //Console.WriteLine("Luong:" + Salary);
        }

        // Hàm trả về danh sách lớp dạy
        public List<string> GetClasses()
        {
            Console.WriteLine("So lop dang day: " + Classes.Count);
            return Classes;
        }
    }
}