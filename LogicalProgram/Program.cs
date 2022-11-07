// Reverse Number Program
using System;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            int rev = 0, rem;
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("reverse no is :" + rev);

        }
    }
}

