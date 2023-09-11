using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca___01.classes
{
    internal class Funcionario:Pessoa
    {
        public double Salario { get; set; }
        public string Siap { get; set; }
        public int CargaHoraria { get; set; }
    }
}
