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
        public void DeveInvocarAcoesPosteriores()
        {
            //IAcaoAposGerarNota acao1 = new Mock<IAcaoAposGerarNota>();
            //IAcaoAposGerarNota acao2 = new Mock<IAcaoAposGerarNota>();
            //IList<AcaoAposGerarNota> acoes = new List<AcaoAposGerarNota>() { acao1.Object, acao2.Object };
            //GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);
            //Pedido pedido = new Pedido("Mauricio", 1000, 1);
            //NotaFiscal nf = gerador.Gera(pedido);
            //acao1.Verify(a => a.Executa(nf));
            //acao2.Verify(a => a.Executa(nf));

            throw new NotImplementedException();
        }

        [Test]
        public void DeveConsultarATabelaParaCalcularValor()
        {
            // mockando uma tabela, que ainda nem existe
            var tabela = new Mock<Tabela>();
            // definindo o futuro comportamento "paraValor",
            // que deve retornar 0.2 caso o valor seja 1000.0
            tabela.Setup(t => t.ParaValor(1000.0)).Returns(0.2);
            IList<IAcaoAposGerarNota> nenhumaAcao =
            new List<IAcaoAposGerarNota>();
            GeradorDeNotaFiscal gerador =
            new GeradorDeNotaFiscal(nenhumaAcao, new RelogioDoSistema(), tabela.Object);
            Pedido pedido = new Pedido("Mauricio", 1000, 1);
            NotaFiscal nf = gerador.Gera(pedido);
            // garantindo que a tabela foi consultada
            tabela.Verify(t => t.ParaValor(1000.0));
            Assert.AreEqual(1000 * 0.2, nf.Valor, 0.00001);
        }
    }
}
