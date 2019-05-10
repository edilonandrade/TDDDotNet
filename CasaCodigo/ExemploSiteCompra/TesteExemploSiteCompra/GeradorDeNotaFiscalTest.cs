using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ExemploSiteCompra;
using Moq;

namespace TesteExemploSiteCompra
{
    [TestFixture]
    public class GeradorDeNotaFiscalTest
    {
        [Test]
        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            //criando Mock
            var dao = new Mock<INFDao>();
            var sap = new Mock<ISAP>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(1000 * 0.94, nf.Valor, 0.0001);

            //verificando que o método foi invocado
            dao.Verify(t => t.Persiste(nf));

        }

        [Test]
        public void DevePersistirNFGerada()
        {
            //criando Mock
            var dao = new Mock<INFDao>();
            var sap = new Mock<ISAP>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            //verificando que o método foi invocado
            dao.Verify(t => t.Persiste(nf));
        }

        [Test]
        public void DeveEnviarNFGeradaParaSAP()
        {
            var dao = new Mock<INFDao>();
            var sap = new Mock<ISAP>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            sap.Verify(t => t.Envia(nf));
        }
    }
}
