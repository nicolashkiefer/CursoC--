using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("//////// Conversão de Tempo ////////");
            Console.Write("Informe um valor: ");
            int N = int.Parse(Console.ReadLine());

            int horas = N / 3600;
            int sobra = N % 3600;

            int minutos = sobra / 60;
            int segundos = sobra % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

            Console.ReadLine();
        }
    }
}
