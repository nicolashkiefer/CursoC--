using System;
using System.Globalization;
using System.Dynamic;
using System.Diagnostics;

namespace bee1018
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Cédulas
            Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

            Entrada
            O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

            Saída
            Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido.*/

            int valor = int.Parse(Console.ReadLine());
            int resto = valor;

            int n100 = resto / 100;
            resto %= 100;

            int n50 = resto / 50;
            resto %= 50;

            int n20 = resto / 20;
            resto %= 20;

            int n10 = resto / 10;
            resto %= 10;

            int n5 = resto / 5;
            resto %= 5;

            int n2 = resto / 2;
            resto %= 2;

            int n1 = resto;

            Console.WriteLine(valor);
            Console.WriteLine(n100 + " nota(s) de R$ 100,00");
            Console.WriteLine(n50 + " nota(s) de R$ 50,00");
            Console.WriteLine(n20 + " nota(s) de R$ 20,00");
            Console.WriteLine(n10 + " nota(s) de R$ 10,00");
            Console.WriteLine(n5 + " nota(s) de R$ 5,00");
            Console.WriteLine(n2 + " nota(s) de R$ 2,00");
            Console.WriteLine(n1 + " nota(s) de R$ 1,00");
        }
    }
}