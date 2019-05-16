using System;
namespace myApp
{
    class StaticVar
    {
        public static int num;
        public void count()
        {
            num ++;
        }

        public int getNum()
        {
            return num;
        }

        public static int getNum2()
        // 把一个成员函数声明为 static。这样的函数只能访问静态变量。
        {
            return num;
        }

    } 
}