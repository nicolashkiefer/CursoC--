using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');
            double a = double.Parse(valor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valor[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2.0) - 4*a*c;

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                double r1 = (- b + Math.Sqrt(delta)) / (2.0*a); 
                double r2 = (- b - Math.Sqrt(delta)) / (2.0*a);

                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}