using System;
using System.Globalization;
using System.Dynamic;
using System.Diagnostics;

namespace bee1008
{
    class Program
    {
        static void Main(String[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());

            double pHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = pHora * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}