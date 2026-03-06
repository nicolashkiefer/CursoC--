using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] numero = Console.ReadLine().Split(' ');
            int x = int.Parse(numero[0]);
            int y = int.Parse(numero[1]);
            int z = int.Parse(numero[2]);

            int menor;

            if (x == y && y == z)
            {
                menor == x;
            }
            else if (x < y && x < z)
            {
                menor == x;
            }
            else if (y < x && y < z)
            {
                menor == y;
            }
            else
            {
                menor == z;
            }



        }
    }
}