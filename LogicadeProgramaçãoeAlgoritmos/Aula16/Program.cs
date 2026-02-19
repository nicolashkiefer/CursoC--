using System;
using System.Globalization;

namespace Aula16
{
    class Program
    {
        static void Main(String[] args)
        {
            // Definido o tipo de variável e inserido o valor/informação correspondente
            double x = 10.35784;
            int y = 21;
            string z = "Nicolas";
            char w = 'M';

            Console.Write("Olá Mundo!"); // Escreve na tela
            Console.WriteLine("Bom dia!"); //Escreve na tela e quebra a linha automaticamente
            Console.WriteLine("Até mais!"); //Escreve na tela e quebra a linha automaticamente

            Console.ReadLine(); //Faz o programa esperar o usuário apertar Enter antes de encerrar.
            Console.WriteLine(x); // Realizado a escrita(saída de dados) da variável.
            Console.WriteLine(x.ToString("F2")); //Realizado a escrita da variável com 2 casas decimais depois da ",".
            Console.WriteLine(x.ToString("F4")); //Realizado a escrita da variável com 4 casas decimais depois da ",".
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // Realizado a escrita da variável com "." ao invés da ",".

            Console.ReadLine();
            Console.WriteLine("Resultado = " + x); //Realizado a escrita e adicionado a variável com concatenação
            Console.WriteLine("O valor do troco é " + x + " reais"); //Realizao a concatenação entre a escrita
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais"); //Realizao a concatenação entre a escrita da variável com 2 casas decimais depois da ",".

            Console.ReadLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é "+ w); // Exemplo com várias variáveis utilizando a concatenação em um mesmo comando de escrita.

            Console.ReadLine();
        }
    }
}