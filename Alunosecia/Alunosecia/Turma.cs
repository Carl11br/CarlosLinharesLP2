using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunosecia
{
    class Turma
    {
        public string Serie { get; set; }
        public int Sala { get; set; }
        public string Nome { get; set; }
        public string LinguaEstrangeira { get; set; }
        public string Tipo { get; set; }
        public string Turno { get; set; }
        public int AnoLetivo { get; set; }
        private List<Aluno> Alunos { get; set; }

        public void AdicionarAluno(Aluno a)
        {
            Alunos.Add(a);
        }
        public Turma()
        {
            Alunos = new List<Aluno>();
        }

        public void ListarAlunos()
        {
            foreach (Aluno a in Alunos)
            {
                Console.WriteLine(a.Nome);
                Console.WriteLine(a.Matricula);
                if (a.Representante == true) Console.WriteLine("Representante");
                else Console.WriteLine("Aluno comum");
            }

        }
    }
}
