using System;

namespace DepartamentoPessoal
{
    public interface IRegraCalculo
    {
        double Calcula(Funcionario f);
    }

    public class DezOuVintePorCento : IRegraCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Salario > 3000) return funcionario.Salario * 0.8;
            return funcionario.Salario * 0.9;
        }
    }

    public class QuinzeOuVinteCincoPorCento : IRegraCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Salario < 2500)
            {
                return funcionario.Salario * 0.85;
            }
            return funcionario.Salario * 0.75;
        }
    }
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            return funcionario.Cargo.Regra.Calcula(funcionario);
           
        }        
    }
}