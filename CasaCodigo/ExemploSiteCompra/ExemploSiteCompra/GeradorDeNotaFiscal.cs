using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSiteCompra
{
    public class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> acoes;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            this.acoes = acoes;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, DateTime.Now);

            foreach(var acao in acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        } 
    }

    public interface IAcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);
    }

    public class AcaoAposGerarNota : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            throw new NotImplementedException();
        }
    }

}
