using System;

namespace DepartamentoPessoal
{
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo.Equals(Tipos.Cargo.DESENVOLVEDOR))
            {
                if (funcionario.Salario > 3000) return funcionario.Salario * 0.8;
                return funcionario.Salario * 0.9;
            }
            return funcionario.Salario  * 0.85;
        }
    }
}