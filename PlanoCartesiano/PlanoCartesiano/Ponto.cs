using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoCartesiano
{
    class Ponto
    {
        public double X {get; set; }
        public double Y { get; set; }
        public Ponto(double X, double Y) 
        {
            this.X = X;
            this.Y = Y;
        }

        public static double Distancia(Ponto p1, Ponto p2)
        {
           return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + (Math.Pow((p1.Y - p2.Y), 2)));

        }

    }
}
