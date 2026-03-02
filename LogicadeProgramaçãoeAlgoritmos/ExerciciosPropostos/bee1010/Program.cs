using System;
using System.Globalization;
using System.Diagnostics;
using System.Dynamic;

namespace bee1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pecas = Console.ReadLine().Split(' ');
            int cod = int.Parse(pecas[0]);
            int numero = int.Parse(pecas[1]);
            double preco = double.Parse(pecas[2], CultureInfo.InvariantCulture);

            pecas = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(pecas[0]);
            int numero2 = int.Parse(pecas[1]);
            double preco2 = double.Parse(pecas[2], CultureInfo.InvariantCulture);

            double valor = (numero*preco) + (numero2*preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}