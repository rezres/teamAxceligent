using System;

namespace teamAxceligent
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
            var maxSum = BiggestNeighborSum.Challenge(input);
            Console.Write($"TestMaxSum for {string.Join(", ",input)} is  {maxSum}");
            Console.ReadKey();
        }
    }
}
