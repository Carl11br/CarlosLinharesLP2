using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunosecia
{
    class Aluno
    {
        public string Nome { get; set; }
        private int nChamada;
        public int NChamada
        { 
            get{return nChamada;}
            set { if (NChamada > 0) nChamada = NChamada;} 
        }
        public string Matricula { get; set; }
        public bool Representante { get; set;}
    }
}
