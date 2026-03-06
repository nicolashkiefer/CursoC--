using System;
using System.Globalization;
using System.Dynamic;
using System.Diagnostics;

namespace bee1015
{
    class Program
    {
        static void Main(String[] args)
        {
            /*  Distância Entre Dois Pontos
            
            Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais, segundo a fórmula:

            Entrada
            O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

            Saída
            Calcule e imprima o valor da distância segundo a fórmula fornecida, considerando 4 casas decimais.*/

            string[] valor = Console.ReadLine().Split(' ');
            double x1 = double.Parse(valor[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(valor[1], CultureInfo.InvariantCulture);

            valor = Console.ReadLine().Split(' ');
            double x2 = double.Parse(valor[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(valor[1], CultureInfo.InvariantCulture);
            
            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InstalledUICulture));
        }
    }
}
