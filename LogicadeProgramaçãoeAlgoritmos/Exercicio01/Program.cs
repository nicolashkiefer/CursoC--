using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("***Calculado de Área e Preço de Terreno***");
            Console.Write("Largura do Terreno: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Comprimento do Terreno: ");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor por metro quadrado: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("ÁREA: " + (largura*comprimento).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO: " + ((largura*comprimento)*valor).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
