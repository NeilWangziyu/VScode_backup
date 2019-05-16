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

    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    class Rectangle2:Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    class Rectangle3
    {
        protected double length;
        protected double width;
        public Rectangle3(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }


    }
    class TableTop:Rectangle3
        {
            private double cost;
            public TableTop(double l, double w):base(l,w)
            { }

            public double GetCost()
            {
                double cost;
                cost = GetArea() * 70;
                return cost;
            }

            public new void Display()
            {
                base.Display();
                Console.WriteLine("cost: {0}", GetCost());

            }
            
        }
    // C# 不支持多重继承。但是，您可以使用接口来实现多重继承。
    public interface PaintCost
    {
        int getCost(int area);

    }

    class Rectangle4:Shape, PaintCost
    {
        public int getArea()
        {
            return (width*height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }

    }

    abstract class ABSShape
    {
        abstract public int area();
    }

    class Rectangle5: ABSShape
    {
        private int length;
        private int width;
        public Rectangle5(int a=0, int b = 0)
        {
            length = a;
            width = b;
        }

        public override int area()
        {
            Console.WriteLine("Rectangle5 class area:");
            return (width*length);
        }
    }

    class ShapeDy
    {
        protected int width, height;
        public ShapeDy(int a=0, int b=0)
        {
            width = a;
            height = b;
        }

        public virtual int area()
        {
            Console.WriteLine("parent area:");
            return 0;
        }
    }
    class Rectangle6:ShapeDy
    {
        public Rectangle6(int a = 0, int b=0):base(a,b)
        {

        }

        public override int area()
        {
            Console.WriteLine("Rectangle6's area");
            return (width*height);
        }

    }

    class Trianle:ShapeDy
    {
        public Trianle(int a= 0, int b = 0):base(a,b)
        { 

        }

        public override int area()
        {
            Console.WriteLine("Triangle class's area");
            return (width*height/2);
        }

    }

    class Caller
    {
        public void CallArea(ShapeDy sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("area:{0}", a);
        }
    }



}