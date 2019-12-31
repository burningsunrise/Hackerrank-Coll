using System;

namespace AVeryBigSum
{
    class Program
    {
        
        static long AVeryBigSum(long[] ar) 
        {
            long sum = 0;
            foreach (var num in ar)
                sum += num;
            return sum;
        }
        
        static void Main(string[] args)
        {
            int arCount = 5;
            long[] ar = {1000000001, 1000000002, 1000000003, 1000000004, 1000000005};
            long result = AVeryBigSum(ar);
            Console.WriteLine(result);
        }
    }
}