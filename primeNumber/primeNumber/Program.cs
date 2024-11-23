using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    internal class Program
    {
        static bool isPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                count += (number % i == 0) ? 1 : 0;
            }
            return count == 2;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
