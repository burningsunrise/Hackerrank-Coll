using System;
using System.IO;

namespace SimpleArraySum
{
    class Program
    {
        private static int SimpleArray(int[] ar)
        {
            int sum = 0;
            foreach (var num in ar)
            {
                sum += num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int arCount = 6;
            int[] ar = new[] {1, 2, 3, 4, 10, 11};
            int result = SimpleArray(ar);
            Console.WriteLine(result);
        }
    }
}