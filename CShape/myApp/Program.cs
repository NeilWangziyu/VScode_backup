#define PI
using System;

namespace myApp
// 命名空间的设计目的是提供一种让一组名称与其他名称分隔开的方式。在一个命名空间中声明的类的名称与另一个命名空间中声明的相同的类的名称不冲突。
{   
    class Box
    {
        public double length;
        public double breadth;
        public double height;

    }

    

    class BoxNew
    {
        private double length;
        private double breadth;

        private double height;

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }

        public double getVolume()
        {
            return length*breadth*height;
        }

        public static BoxNew operator+ (BoxNew b, BoxNew c)
        // 运算符重载
        {
            BoxNew box = new BoxNew();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

        public static bool operator == (BoxNew lhs, BoxNew rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height 
            && lhs.breadth == rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator != (BoxNew lhs, BoxNew rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.height != rhs.height 
            || lhs.breadth != rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator < (BoxNew lhs, BoxNew rhs)
        {
            bool status = false;
            if (lhs.length < rhs.length && lhs.height 
              < rhs.height && lhs.breadth < rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator > (BoxNew lhs, BoxNew rhs)
        {
            bool status = false;
            if (lhs.length > rhs.length && lhs.height 
              > rhs.height && lhs.breadth > rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public override string ToString()
        {
            return  String.Format("({0}, {1}, {2})", length, breadth, height);
        }
    }

    class Line
    {
        private double length;
        public Line()
        {
            Console.WriteLine("class has been create");
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

    }

    class LineNew
    {
        private double length;
        public LineNew(double len)
        {
            // 参数化构造函数
            Console.WriteLine("class LineNew is create, length={0}", length);
            length = len;
        }
        ~LineNew()
        {
            Console.WriteLine("the LineNew class is deleted");
        }

        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

    }

    class Printdata
    {
        public void print(int i)
        {
            Console.WriteLine("Printing int:{0}",i);
        }
        public void print(double f)
        {
            Console.WriteLine("Printing float :{0}", f);
        }

        public void print(string s)
        {
            Console.WriteLine("Printing string:{0}", s);
        }

    }


    class Program
    {
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        // enum should be inside a class

        static void Main(string[] args)
        {   
            // Console.WriteLine("Hello World!\n");
            // Console.WriteLine("The current time is " + DateTime.Now);
            MyClass c1 = new MyClass();
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");

            // int [] balance = new int[] {1000,2,3,17,50};
            // double avg;
            // avg = c1.getAverage(balance, 5);

            // Console.WriteLine("mean value is {0}", avg);

            // int sumvalue = c1.AddElements(512, 720, 250, 567, 889);
            // Console.WriteLine("the sum of the arr is {0}", sumvalue);




            // Rectangle r = new Rectangle();
            // r.Acceptdetails();
            // r.Display();
            // Console.ReadLine();

            // RectangleNew r = new RectangleNew();
            // r.Acceptdetails();
            // r.Display();

            // Console.WriteLine("Size of int: {0}", sizeof(int));

            // string str = "C:\\windows";
            // string str2 = @"C:\windows";
            // Console.Write(str);
            // Console.Write(str2);

            // double d = 5674.74;
            // int i;
            // i = (int)d;
            // Console.WriteLine(i);

            // int inx = 75;
            // float f = 53.005f;

            // Console.WriteLine(inx.ToString());
            // Console.WriteLine(f.ToString());

            // short a;
            // int b;
            // double c;
            // a = 10;
            // b = 20;
            // c = a + b;
            // Console.WriteLine("a = {0}, b = {1}, c={2} ", a,b,c);

            // int number;
            // number = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Number is {0}", number);


            // ConstTest mc = new ConstTest(11,22);
            // Console.WriteLine("x = {0}, y = {1}", mc.x, mc.y);
            // Console.WriteLine("c1 = {0}, c2 = {1}", ConstTest.c1, ConstTest.c2);
            
            // while(a > 5)
            // {
            //     Console.WriteLine("a = {0}", a);
            //     a --;
            // }

            // for (b = 10; b < 15; b = b + 2)
            // {
            //     Console.WriteLine("b = {0}", b);
            // }

            // int[] fibarray = new int[] {0, 1, 1, 2, 3, 5, 8, 13};
            // foreach (int element in fibarray)
            // {
            //     System.Console.WriteLine(element);
            // }
            // System.Console.WriteLine();

            // for (i = 0; i < fibarray.Length; i++)
            // {
            //     System.Console.WriteLine(fibarray[i]);
            // }
            // System.Console.WriteLine();

            // int count = 0;
            // foreach (int element in fibarray)
            // {
            //     count += 1;
            //     System.Console.WriteLine("Element # {0}: {1}", count, element);
            // }
            // System.Console.WriteLine("Number of elements in the array :{0}", count);

            // int j;

            // for (i = 2; i < 100; i ++ )
            // {
            //     for (j = 2; j <= (i / j); j++)
            //         if ((i%j) == 0) break;
            //     if (j > (i / j))
            //         Console.WriteLine("{0} is prime", i);

            // }
            // int a = 20;
            // int b = 14;
            // int ret;
            // NumberManipulator n = new NumberManipulator();
            // ret = n.FindMax(a, b);
            // Console.WriteLine("max number is {0}", ret);

            // Console.WriteLine("6's ! is {0}", n.factorial(6));
            // Console.WriteLine("7's ! is {0}", n.factorial(7));
            
            // Console.WriteLine("在交换之前，a 的值： {0}", a);
            // Console.WriteLine("在交换之前，b 的值： {0}", b);
            
            // /* 调用函数来交换值 */
            // n.swap(a, b);
            
            // Console.WriteLine("在交换之后，a 的值： {0}", a);
            // Console.WriteLine("在交换之后，b 的值： {0}", b);

            // Console.WriteLine("在交换2之前，a 的值： {0}", a);
            // Console.WriteLine("在交换2之前，b 的值： {0}", b);
            
            // /* 调用函数来交换值 */
            // n.swap2(ref a, ref b);
            
            // Console.WriteLine("在交换2之后，a 的值： {0}", a);
            // Console.WriteLine("在交换2之后，b 的值： {0}", b);

            // int a = 100;
         
            // Console.WriteLine("在方法调用之前，a 的值： {0}", a);
            
            /* 调用函数来获取值 */
            // n.getValue(out a);

            // Console.WriteLine("在方法调用之后，a 的值： {0}", a);

            // int x, y;
            // n.getValues(out x, out y);
            // Console.WriteLine(" x: {0}, y: {1}", x, y);


            // int ? num1 = null;
            // int ? num2 = 45;
            // double ? num3 = new double ? ();
            // double ? num4 = 3.14157;
            // bool ? boolval = new bool ? ();

            // Console.WriteLine("显示可空类型的值： {0}, {1}, {2}, {3}", 
            //                 num1, num2, num3, num4);
            // Console.WriteLine("一个可空的布尔值： {0}", boolval);
 
            // double[] balance = new double[10];

            // balance[0] = 4500;

            // Console.WriteLine(balance[0]);
            // Console.WriteLine(balance[1]);

            // int [] n = new int[10];
            // int i, j;

            // for (i = 0; i < 10; i++)
            // {
            //     n[i] = i + 100;
            // }
            // for(j=0;j<10;j++)
            // {
            //     Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            // }
            // // Console.ReadKey();

            // foreach(int x in n)
            // {
            //     int y = x - 100;
            //     Console.WriteLine("element[{0}] = {1}", y,x);
                
            // }

            // 多维数组
            // int [,] a = new int [3,4]
            // {
            //     {0,1,2,3},
            //     {4,5,6,7},
            //     {8,9,10,11}
            // };

            // int val = a[2,3];
            // Console.WriteLine("{0}", val);

            // int[,] b = new int [ 5,2]
            // {{0,0}, {1,2}, {2,4}, {3,6}, {4,8}};

            // int i, j;
            // for (i = 0; i < 5; i ++)
            // {
            //     for(j = 0; j < 2; j++)
            //     {
            //         Console.WriteLine("a[{0},{1}] = {2}", i, j, b[i,j]);
            //     }
            // }

            // 交错数组
            // 交错数组与二维数组的区别，可以直观的理解为交错数组每一行的长度是可以不一样的。

            // int[][] scores = new int [5][];
            // for (int k = 0; k < scores.Length; k++)
            // {
            //     scores[k] = new int[4];
            // }

            // string fname, lname;
            // fname = "Rowan";
            // lname = "Atkinson";
            // string fullname = fname + lname;
            // Console.WriteLine("Full Name:{0}", fullname);

            // char [] letters = {'H', 'e', 'l', 'l', 'o'};
            // string greeetings = new string(letters);
            // Console.WriteLine("Greeting:{0}", greeetings);

            // string[] sarray = {"hello", "From", "Tutorials", "points"};
            // string message = String.Join(" ",sarray);
            // Console.WriteLine("MESSAGE:{0}", message);

            // DateTime waiting = new DateTime(2012, 10, 10, 17, 58,1);
            // string cat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            // Console.WriteLine("Message: {0}", cat);


            // string str1 = "this is text";
            // string str2 = "this is text";
            // if (String.Compare(str1, str2)==0)
            // {
            //     Console.WriteLine(str1 + " and " + str2 +  " are equal.");
            // }
            // else{
            //     Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            // }

            // if (str1.Contains("text"))
            // {
            //     Console.WriteLine("The sequence 'test' was found.");
            // }

            // int x = (int)Day.Sun;
            // int y = (int)Day.Fri;
            // Console.WriteLine("Sun = {0}", x);
            // Console.WriteLine("Fri = {0}", y);


            // Box Box1 = new Box();
            // Box Box2 = new Box();
            // double volume = 0;
            
            // Box1.height = 5.0;
            // Box1.length = 6.0;
            // Box1.breadth = 7.0;

            // // Box2 详述
            // Box2.height = 10.0;
            // Box2.length = 12.0;
            // Box2.breadth = 13.0;

            // // Box1 的体积
            // volume = Box1.height * Box1.length * Box1.breadth;
            // Console.WriteLine("Box1 的体积： {0}",  volume);

            // // Box2 的体积
            // volume = Box2.height * Box2.length * Box2.breadth;
            // Console.WriteLine("Box2 的体积： {0}", volume);



            // BoxNew Boxnew1 = new BoxNew();
            // BoxNew Boxnew2 = new BoxNew();

            // double volumenew;

            // // Box1 详述
            // Boxnew1.setLength(6.0);
            // Boxnew1.setBreadth(7.0);
            // Boxnew1.setHeight(5.0);

            // // Box2 详述
            // Boxnew2.setLength(12.0);
            // Boxnew2.setBreadth(13.0);
            // Boxnew2.setHeight(10.0);
       
            // // Box1 的体积
            // volumenew = Boxnew1.getVolume();
            // Console.WriteLine("Box1 的体积： {0}" ,volumenew);

            // // Box2 的体积
            // volumenew = Boxnew2.getVolume();
            // Console.WriteLine("Box2 的体积： {0}", volumenew);

            // Line line = new Line();
            // line.setLength(6.0);
            // Console.WriteLine("the length is {0}", line.getLength());


            // LineNew linenew = new LineNew(10);
            // Console.WriteLine("linenew的长度： {0}", linenew.getLength()); 
            // // 设置线条长度
            // linenew.setLength(6.0);
            // Console.WriteLine("linenew的长度： {0}", linenew.getLength()); 

            // StaticVar s1 = new StaticVar();
            // StaticVar s2 = new StaticVar();
            // s1.count();
            // s1.count();
            // s1.count();
            // s2.count();
            // s2.count();
            // s2.count();         
            // Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
            // Console.WriteLine("s2 的变量 num： {0}", s2.getNum());   

            // Rectangle2 rec = new Rectangle2();
            // rec.setHeight(5);
            // rec.setWidth(7);

            // Console.WriteLine("area:{0}", rec.getArea());

            // TableTop t = new TableTop(4.5, 7.5);
            // t.Display();

            // Rectangle4 RECT = new Rectangle4();
            // int area;
            // RECT.setHeight(5);
            // RECT.setWidth(7);
            // area = RECT.getArea();
            // Console.WriteLine("total area: {0}", RECT.getArea());
            // Console.WriteLine("total painting cost {0}", RECT.getCost(area));

            Printdata p = new Printdata();
            p.print(5);
            p.print(500.23432);
            p.print("Hello C#");

            Rectangle5 r =  new Rectangle5(10,7);
            double a = r.area();
            Console.WriteLine("area : {0}", a);
            // 静态多态性通过函数重载和运算符重载
            // 动态多态性是通过 抽象类 和 虚方法 实现的。

            Caller c = new Caller();
            Rectangle6 r6 = new Rectangle6(10, 7);
            Trianle t = new Trianle(10, 5);
            c.CallArea(t);
            c.CallArea(r6);

            BoxNew Box1 = new BoxNew();         // 声明 Box1，类型为 BoxNew
            BoxNew Box2 = new BoxNew();         // 声明 Box2，类型为 BoxNew
            BoxNew Box3 = new BoxNew();         // 声明 Box3，类型为 BoxNew
            double volume = 0.0;          // 体积

            // Box1 详述
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // Box2 详述
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            // Box1 的体积
            volume = Box1.getVolume();
            Console.WriteLine("Box1 的体积： {0}", volume);

            // Box2 的体积
            volume = Box2.getVolume();
            Console.WriteLine("Box2 的体积： {0}", volume);

            // 把两个对象相加
            Box3 = Box1 + Box2;

            // Box3 的体积
            volume = Box3.getVolume();
            Console.WriteLine("Box3 的体积： {0}", volume);

            #if(PI)
                Console.WriteLine("PI is defined");
            #else 
                Console.WriteLine("PI is not defined");
            #endif

        }

    }
}
