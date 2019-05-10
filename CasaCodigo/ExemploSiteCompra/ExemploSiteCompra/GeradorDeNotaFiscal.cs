using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSiteCompra
{
    public class GeradorDeNotaFiscal
    {
        private INFDao dao;
        private ISAP sap;
        //private sealed IList<IAcaoAposGerarNota> acoes;

        public GeradorDeNotaFiscal(INFDao dao, ISAP sap)
        {
            this.dao = dao;
            this.sap = sap;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, DateTime.Now);

            dao.Persiste(nf);
            sap.Envia(nf);

            return nf;
        }

        public interface IAcaoAposGerarNota
        {
            void Executa(NotaFiscal nf);
        }

            
    }
}
