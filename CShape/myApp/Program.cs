using System;

namespace myApp
{
    class Program
    {
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {   
            // Console.WriteLine("Hello World!\n");
            // Console.WriteLine("The current time is " + DateTime.Now);
            MyClass c1 = new MyClass();
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");

            int [] balance = new int[] {1000,2,3,17,50};
            double avg;
            avg = c1.getAverage(balance, 5);

            Console.WriteLine("mean value is {0}", avg);

            int sumvalue = c1.AddElements(512, 720, 250, 567, 889);
            Console.WriteLine("the sum of the arr is {0}", sumvalue);




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

            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";
            string fullname = fname + lname;
            Console.WriteLine("Full Name:{0}", fullname);

            char [] letters = {'H', 'e', 'l', 'l', 'o'};
            string greeetings = new string(letters);
            Console.WriteLine("Greeting:{0}", greeetings);

            string[] sarray = {"hello", "From", "Tutorials", "points"};
            string message = String.Join(" ",sarray);
            Console.WriteLine("MESSAGE:{0}", message);

            DateTime waiting = new DateTime(2012, 10, 10, 17, 58,1);
            string cat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", cat);


            string str1 = "this is text";
            string str2 = "this is text";
            if (String.Compare(str1, str2)==0)
            {
                Console.WriteLine(str1 + " and " + str2 +  " are equal.");
            }
            else{
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }

            if (str1.Contains("text"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }

            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);



            






        }
    }
}
