using System;
using System.Globalization;

namespace bee1021
{
    class Program
    {
        static void Main(String[] args)
        {
            /*  Notas e Moedas
            Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

            Entrada
            O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

            Saída
            Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

            Obs: Utilize ponto (.) para separar a parte decimal.*/

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int resto = (int)Math.Round(valor * 100.0);

            int n100 = resto / (100*100);
            resto = resto % (100 * 100);

            int n50 = resto / (50*100);
            resto = resto % (50*100);

            int n20 = resto / (20*100);
            resto = resto % (20*100);
            
            int n10 = resto / (10*100);
            resto = resto % (10*100);

            int n5 = resto / (5*100);
            resto = resto % (5*100);

            int n2 = resto / (2*100);
            resto = resto % (2*100);

            int m1 = resto / (1*100);
            resto = resto % (1*100); 

            int m05 = resto / 50;
            resto %= 50;

            int m025 = resto / 25;
            resto %= 25;

            int m010 = resto / 10;
            resto %= 10; 

            int m005 = resto / 5;
            resto %= 5;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(n100 + " nota(s) de R$ 100.00");
            Console.WriteLine(n50 + " nota(s) de R$ 50.00");
            Console.WriteLine(n20 + " nota(s) de R$ 20.00");
            Console.WriteLine(n10 + " nota(s) de R$ 10.00");
            Console.WriteLine(n5 + " nota(s) de R$ 5.00");
            Console.WriteLine(n2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(m1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(m05 + " moeda(s) de R$ 0.50");
            Console.WriteLine(m025 + " moeda(s) de R$ 0.25");
            Console.WriteLine(m010 + " moeda(s) de R$ 0.10");
            Console.WriteLine(m005 + " moeda(s) de R$ 0.05");
            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
        }
    }
}