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
    }
}
