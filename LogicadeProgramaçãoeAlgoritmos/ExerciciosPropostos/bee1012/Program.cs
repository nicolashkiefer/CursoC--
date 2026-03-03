using System;
using System.Globalization;
using System.Dynamic;
using System.Diagnostics;

namespace bee1012
{
    class Program
    {
        static void Main(string[] args){
            /*Área

            Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.

            Entrada
            O arquivo de entrada contém três valores com um dígito após o ponto decimal.

            Saída
            O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.*/

            string[] valor = Console.ReadLine().Split(' ');
            double A = double.Parse(valor[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valor[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valor[2], CultureInfo.InvariantCulture);
            
            double areaTriangulo = (A * C) / 2.0;
            double areaCirculo = 3.14159 * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2.0;
            double areaQuadrado = Math.Pow(B, 2);
            double areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: "+ areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "+ areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+ areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+ areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: "+ areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
