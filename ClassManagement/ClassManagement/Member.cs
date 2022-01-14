using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagement
{
    internal class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public void DisplayBasicInformation()
        {
            Console.WriteLine("Ten: " + Name);
            Console.WriteLine("Tuoi: " + Age);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("SDT: " + PhoneNumber);
        }
    }
}