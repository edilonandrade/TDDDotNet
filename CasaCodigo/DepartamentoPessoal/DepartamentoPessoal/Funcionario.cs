using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartamentoPessoal
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public Tipos.Cargo Cargo { get; private set; }

        public Funcionario(string nome, double salario, Tipos.Cargo cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }
    }
}
