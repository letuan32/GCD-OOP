using System;

namespace ClassObject
{
    internal class Drinks
    {
        // Declare fields
        private string name;

        private string brand;
        private double price;

        // Create methos
        public Drinks()
        {
            name = "Default Name";
            brand = "Unknow";
        }

        public void GetDetail()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Price:: " + price);
        }

        public void UpdatePrice(double newPrice)
        {
            this.price = newPrice;
            Console.WriteLine("New price: " + price);
        }

        private static void Main(string[] args)
        {
            Drinks coca = new Drinks();
            // Gắn giá trị cho trường dữ liệu
            //coca.name = "Coca Cola";
            //coca.brand = "Cocacola";
            //coca.price = 0.5;
            //// Truy cập, lấy giá trị của trường
            //Console.WriteLine("Name: " + coca.name);

            Console.WriteLine("Truy cap methods");
            coca.UpdatePrice(1);
            coca.GetDetail();
        }
    }
}