using System;
namespace myApp
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

        public int factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else{
                result = factorial(num - 1) * num;
                return result;
            }

        }

        public void swap(int x, int y)
        {
            // 按值传递参数
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        public void swap2(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        public void getValue(out int x)
        {   
            // 按输出传递参数
            int temp = 5;
            x = temp;
        }

        public void getValues(out int x, out int y)
        {
            Console.WriteLine("please input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input second number");
            y = Convert.ToInt32(Console.ReadLine());
            
                
            
        }
    }
}