using System;
namespace myApp
{
    class RectangleNew
    {
        private double length;
        private double width;
        public void Acceptdetails()
        {
            Console.WriteLine("Print input length:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please input width: ");
            width = Convert.ToDouble(Console.ReadLine());

        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("length {0}", length);
            Console.WriteLine("width {0}", width);
            Console.WriteLine("area: {0}", GetArea());
        }
    }

}