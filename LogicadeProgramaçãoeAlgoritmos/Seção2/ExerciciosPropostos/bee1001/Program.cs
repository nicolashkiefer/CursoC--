using System;
using System.Diagnostics;

namespace bee1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine().Trim());
            int B = int.Parse(Console.ReadLine().Trim());

            int X = A + B;

            Console.WriteLine("X=" + X);
        }
    }
}