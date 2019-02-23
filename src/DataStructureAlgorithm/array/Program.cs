using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            OutOfRangeException();
            Console.ReadKey();
        }

        private static void  OutOfRangeException()
        {
            int i = 0;
            var arr = new int[3];
            for (; i <= 3; i++)
            {
                arr[i] = 0;
                Console.WriteLine("hello world\n");
            }
        }
    }
}
