using System;
using System.Globalization;

namespace bee1020
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Idade em Dias

            Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

            Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

            Entrada
            O arquivo de entrada contém um valor inteiro.

            Saída
            Imprima a saída conforme exemplo fornecido.*/

            int idade = int.Parse(Console.ReadLine());
            int restante = idade;

            int ano = restante / 365;
            restante %= 365;

            int mes = restante / 30;
            restante %= 30;

            int dia = restante;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}