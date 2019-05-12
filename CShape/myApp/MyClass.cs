using System;
namespace myApp
{
    class MyClass
    {
        public string ReturnMessage()
        {
            return "Happy coding!";
        }

        public double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;
            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }

            avg = (double) sum / size;
            return avg;

        }

        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }



    }
    
}