using System;

namespace DepartamentoPessoal
{
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo.Equals(Tipos.Cargo.DESENVOLVEDOR))
            {
                return DezOuVintePorCentoDeDesconto(funcionario);                
            }
            else if (funcionario.Cargo.Equals(Tipos.Cargo.DBA) || funcionario.Cargo.Equals(Tipos.Cargo.TESTADOR))
            {
                return QuinzeOuVinteCincoPorCentoDeDesconto(funcionario);
            }

            throw new Exception("Funcionário inválido.");
           
        }

        private double QuinzeOuVinteCincoPorCentoDeDesconto(Funcionario funcionario)
        {
            if (funcionario.Salario < 2500)
            {
                return funcionario.Salario * 0.85;
            }
            return funcionario.Salario * 0.75;
        }

        private double DezOuVintePorCentoDeDesconto(Funcionario funcionario)
        {
            if (funcionario.Salario > 3000) return funcionario.Salario * 0.8;
            return funcionario.Salario * 0.9;
        }
    }
}