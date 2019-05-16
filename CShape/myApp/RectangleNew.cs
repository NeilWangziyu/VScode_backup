using System;
namespace myApp
{
    class RectangleNew
    {
        private double length;
        // private：private表示私有，私有的意思就是除了class自己之外，任何人都不可以直接使用，
        // 即便是子女，朋友，都不可以使用。
        // protected：protected对于子女、朋友来说，就是public的，可以自由使用，没有任何限制，
        // 而对于其他的外部class，protected就变成private
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