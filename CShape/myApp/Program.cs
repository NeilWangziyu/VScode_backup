using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Console.WriteLine("Hello World!\n");
            // Console.WriteLine("The current time is " + DateTime.Now);
            MyClass c1 = new MyClass();
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");

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
            NumberManipulator n = new NumberManipulator();
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

            int a = 100;
         
            Console.WriteLine("在方法调用之前，a 的值： {0}", a);
            
            /* 调用函数来获取值 */
            n.getValue(out a);

            Console.WriteLine("在方法调用之后，a 的值： {0}", a);

            int x, y;
            n.getValues(out x, out y);
            Console.WriteLine(" x: {0}, y: {1}", x, y);







        }
    }
}
