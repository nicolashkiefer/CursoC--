using System;
using System.Globalization;
using System.Diagnostics;

namespace bee1004
{
    class Program
    {
        static void Main(String[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = "+ PROD);
        }
    }
}