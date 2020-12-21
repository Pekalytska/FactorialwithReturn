using System;

namespace Factorial
{
    class Program
    {
        static ulong Factorial(uint min, int factorial, ulong iEmul)
        {
            if (min <= factorial)
            {
                iEmul = iEmul * min;
                min++;
                return Factorial(min, factorial, iEmul);
            }
            return iEmul;
        }
        static void Main(string[] args)
        {
            uint min = 1;
            int factorial = Int32.Parse(Console.ReadLine()); //max 20
            ulong iEmul = 1;
            ulong factor = Factorial(min, factorial, iEmul);
            Console.WriteLine(factor);
        }
    }
}
