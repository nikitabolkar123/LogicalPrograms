// Coupen Number Program
using System;
using System.Linq;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string result = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
            Console.WriteLine(result);

        }
    }
}