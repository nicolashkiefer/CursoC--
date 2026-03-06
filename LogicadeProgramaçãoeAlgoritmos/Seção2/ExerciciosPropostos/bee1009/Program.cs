using System;
using System.Globalization;
using System.Dynamic;
using System.Diagnostics;

namespace bee1009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Primeiro nome do vendedor: ");
            string nome = Console.ReadLine();
            double salarioF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalV = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //15% = 0,15
            double salario = salarioF + totalV * 0.15;

            Console.WriteLine("TOTAL = R$" + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}