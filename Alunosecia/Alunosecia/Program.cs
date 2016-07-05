using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunosecia
{
    class Program
    {
        static void Main(string[] args)
        {
            Turma in213 = new Turma();
            in213.Nome = "In213";
            in213.Sala = 05;
            in213.Turno = "Manhã";
            in213.Tipo = "Integrado";
            in213.Serie = "2° série Ensino Médio";
            in213.LinguaEstrangeira = "Inglês";
            for (int i = 0; i < 3; i++)
            {
                Aluno a1 = new Aluno();
                Console.Write("Nome :");
                a1.Nome = Console.ReadLine();
                Console.Clear();
                Console.Write("Número de Matrícula: ");
                a1.Matricula = Console.ReadLine();
                Console.Clear();
                Console.Write("O aluno é representante?");
                string resposta = Console.ReadLine();
                if (resposta == "Sim" || resposta == "sim" || resposta == "s" || resposta == "S") a1.Representante = true;
               in213.AdicionarAluno(a1);
                Console.Clear();
            }
            in213.ListarAlunos();
            Console.ReadKey();
        }
    }
}
