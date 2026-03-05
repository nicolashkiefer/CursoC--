using System;
using System.Globalization;

namespace Aula33
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Quantas horas? ");
            int horas = int.Parse(Console.ReadLine());

            if (horas < 12){
                Console.WriteLine("Bom dia!");
            }
            else {
                if (horas < 18) {
                    Console.WriteLine("Boa tarde!");
                }
                else {
                    Console.WriteLine("Boa noite!");
                }
            }

            Console.ReadLine();
        }
    }
}