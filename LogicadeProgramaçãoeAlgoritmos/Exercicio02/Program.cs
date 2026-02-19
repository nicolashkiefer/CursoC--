using System;
using System.Globalization;
using System.Text;

namespace Exercicio02
{
    class Programam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Calculadora de Retãngulo***");
            Console.Write("Informe o valor da Base de um triângulo: ");
            double baset = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor da Altura do Trinângulo: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = baset * altura;
            double diagonal = Math.Sqrt(Math.Pow(baset, 2.0) + Math.Pow(altura, 2.0));
            double perimetro = (baset*2) + (altura*2);

            Console.WriteLine("ÁREA: " + area.ToString("F4", CultureInfo.InstalledUICulture));
            Console.WriteLine("PERIMETRO: " + perimetro.ToString("F4", CultureInfo.InstalledUICulture));
            Console.WriteLine("DIAGONAL: " + diagonal.ToString("F4", CultureInfo.InstalledUICulture));

            Console.ReadLine();
        }
    }
}
