// Stimulate Watch Program
using System;
using System.Diagnostics;
using System.Linq;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Nikita Raju Bolkar");
            }

            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",
                stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}