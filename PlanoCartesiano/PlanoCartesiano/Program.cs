using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoCartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ponto> pontos = new List<Ponto>();
            double sx = 0, sy = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Ponto p = new Ponto(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()));
                pontos.Add(p);
                sx += pontos[i].X;
                sy += pontos[i].Y;
            }

            Ponto pontomedio = new Ponto(sx / n, sy / n);
            Console.WriteLine("Ponto médio: {0} e {1}",pontomedio.X,pontomedio.Y);
            double perimetro = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == n -1)
                {
                  Console.WriteLine(perimetro += Ponto.Distancia(pontos[i], pontos[0]));
                }
               else Console.WriteLine(perimetro += Ponto.Distancia(pontos[i], pontos[i + 1]));

            }
            Console.WriteLine(perimetro);
           
        }
    }
}
