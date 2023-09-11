using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca___01.classes
{
    internal class Aluno:Pessoa
    {
        public string Responsavel { get; set; }
        public string Turma { get; set; }
        public string Matricula { get; set; }
    }
}
