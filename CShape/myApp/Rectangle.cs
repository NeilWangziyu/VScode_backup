using System;
namespace myApp
{
    class Rectangle
    {
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area:{0}", GetArea());

        }
    }

}