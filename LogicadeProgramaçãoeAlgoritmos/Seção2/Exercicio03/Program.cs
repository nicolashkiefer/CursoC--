using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro nome e idade de uma pessoa: ");
            string[] pessoa = Console.ReadLine().Split(' ');
            string nomeP1 = pessoa[0];
            int idadeP1 = int.Parse(pessoa[1], CultureInfo.InvariantCulture);
           
            Console.Write("Digite outro primeiro nome e idade de uma pessoa: ");
            pessoa = Console.ReadLine().Split(' ');
            string nomeP2 = pessoa[0];
            int idadeP2 = int.Parse(pessoa[1], CultureInfo.InvariantCulture);

            double media = (double)(idadeP1 + idadeP2) / 2.0;

            Console.WriteLine("A idade médio de " + nomeP1 + " e " + nomeP2 +" é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos!");

            Console.ReadLine();
        }
    }
}