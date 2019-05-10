﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ProcessadorDeBoletos
{
    [TestFixture]
    public class ProcessadorDeBoletosTest
    {
        [Test]
        public void DeveProcessarPagamentoViaBoletoUnico()
        {
            ProcessadorDeBoletos processador = new ProcessadorDeBoletos();

            Fatura fatura = new Fatura("Cliente", 150.0);

            Boleto b1 = new Boleto(150.0);

            IList<Boleto> boletos = new List<Boleto>() { b1 };

            processador.Processa(boletos, fatura);

            Assert.AreEqual(1, fatura.Pagamentos.Count);
            Assert.AreEqual(150.0, fatura.Pagamentos[0].Valor, 0.00001);

        }
    }
}