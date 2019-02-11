using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = Cal(10);
            var sum2 = Cal2(3);
            Console.WriteLine(sum);
            Console.WriteLine(sum2);
            Console.ReadKey();
        }

        private static int Cal(int n)
        {
            var sum = 0;
            var i = 1;
            for (; i <= n; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        private static int Cal2(int n)
        {
            var sum = 0;
            var i = 1;
            for (; i <= n; i++)
            {
                var j = 1;
                for (; j <= n; j++)
                {
                    sum = sum + i * j;
                }
            }

            return sum;
        }
    }
}
