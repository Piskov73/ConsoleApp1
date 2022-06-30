using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb=int.Parse(Console.ReadLine());
            BigInteger bigFactorial = 1;
            for (int i = 1; i <= numb; i++)
            {
                bigFactorial *= i;
            }
            Console.WriteLine(bigFactorial);
        }
    }
}
