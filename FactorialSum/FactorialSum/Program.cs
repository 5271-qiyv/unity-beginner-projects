using System.Numerics;
using System;
namespace FactorialSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger sum=0;
            BigInteger factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial;
            }
            Console.WriteLine(sum);
        }
    }
}
