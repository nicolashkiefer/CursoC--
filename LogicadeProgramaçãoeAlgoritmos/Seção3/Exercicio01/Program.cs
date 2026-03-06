using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaF = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + notaF.ToString("F1", CultureInfo.InvariantCulture));

            if (notaF < 60.00)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}