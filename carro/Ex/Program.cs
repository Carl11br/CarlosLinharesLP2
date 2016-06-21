using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Carro> carros = new List<Carro>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Carro c = new Carro();
                c.Placa = Console.ReadLine();
                c.Modelo = Console.ReadLine();
                c.Ano = int.Parse(Console.ReadLine());
                carros.Add(c);
            }
            Console.WriteLine("Digite a placa do carro que você deseja obter os dados:");
            int con = 0;
            string placa = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (carros[i].Placa == placa)
                {
                    Console.WriteLine(carros[i].Ano);
                    Console.WriteLine(carros[i].Modelo);
                    break;
                }
                else
                    con++;
            }
            if (con == n)
                Console.WriteLine("A placa digitada não pertence a nenhum carro cadastrado.");
            Console.WriteLine("Muito obrigado por utilizar o nosso software, volte sempre. Ah, lembre-se: Use  cinto de segurança.Ah, outra coisa, não pule da escada de Madureira.");
        }
    }
}