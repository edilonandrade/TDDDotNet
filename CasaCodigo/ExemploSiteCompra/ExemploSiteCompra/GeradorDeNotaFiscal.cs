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
        private IRelogio relogio;
        private ITabela Tabela;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio, ITabela tabela)
        {
            this.acoes = acoes;
            this.relogio = relogio;
            this.Tabela = tabela;
        }

        //construtor sem relógio para não quebrar o resto do sistema
        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes) : this(acoes, new RelogioDoSistema(), new Tabela()) { }

        public NotaFiscal Gera(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(pedido.Cliente, 
                pedido.ValorTotal * Tabela.ParaValor(pedido.ValorTotal),
                relogio.Hoje());

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

    public interface ITabela
    {
        double ParaValor(double valor);
    }

    public class Tabela : ITabela
    {
        public double ParaValor(double valor)
        {
            throw new NotImplementedException();
        }
    }

}
