using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DepartamentoPessoal
{
    [TestFixture]
    public class CalculadoraDeSalarioTest
    {
        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.0, Tipos.Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(desenvolvedor.Salario * 0.9, salario, 0.00001);

        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario("Mauricio", 4000.0, Tipos.Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(desenvolvedor.Salario * 0.8, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario dba = new Funcionario("Mauricio", 500.0, Tipos.Cargo.DBA);

            double salario = calculadora.CalculaSalario(dba);

            Assert.AreEqual(dba.Salario * 0.85, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario dba = new Funcionario("Mauricio", 4500.0, Tipos.Cargo.DBA);

            double salario = calculadora.CalculaSalario(dba);

            Assert.AreEqual(4500.0 * 0.75, salario, 0.00001);

        }
    }
}
