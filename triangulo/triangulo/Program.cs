using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos triângulos você quer analisar: ");
            int n = int.Parse(Console.ReadLine());
            double perimetro = 0;
            double aux;
            int id = 0;
            Triangulo t = new Triangulo(10, 15, 20);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o id do triângulo:");
                t.id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o tamanho do lado 1:");
                t.Lado1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o tamanho do lado 2:");
                t.Lado2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o tamanho do lado 3:");
                t.Lado3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o código da cor do triângulo:");
                t.Cor = double.Parse(Console.ReadLine());
                aux = t.Lado1 + t.Lado2 + t.Lado3;
                if (aux > perimetro)
                {
                    perimetro = aux;
                    id = t.id;
                }
                Console.Clear();

            }
            Console.WriteLine("O triângulo de maior perímetro é o {0}, cujo perímetro igual a {1}.", id, perimetro);


        }
    }
}
