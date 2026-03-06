using System;
using System.Globalization;

namespace bee1019
{
    class Program
    {
        static void Main(String[] args)
        {
            /*  Conversão de Tempo
            Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

            Entrada
            O arquivo de entrada contém um valor inteiro N.

            Saída
            Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.*/

            int valor = int.Parse(Console.ReadLine());
            int resto = valor;

            int horas = resto / 3600;
            resto %= 3600;

            int minutos = resto / 60;
            resto %= 60;

            int segundos = resto;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}