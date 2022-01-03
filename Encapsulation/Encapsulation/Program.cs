using System;

namespace RectangleApplication
{
    internal class Rectangle
    {
        // Fields
        private string _name = "UoG";

        private double _length;
        private double _width;

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public double Width
        {
            set { _width = value; }
            get { return _width; }
        }

        // Method
        public double GetArea()
        {
            return _length * _width;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            //rectangle.Length = 3.5;
            //rectangle.Width = 2.5;
            //Console.WriteLine(rectangle.Width);
            //Console.WriteLine(rectangle.Length);
            Console.WriteLine(rectangle.Name);
        }
    }
}