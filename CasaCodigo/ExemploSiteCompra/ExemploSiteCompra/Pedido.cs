using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSiteCompra
{
    public class Pedido
    {
        public string Cliente { get; private set; }
        public double ValorTotal { get; private set; }
        public int QuantidadeItens { get; private set; }

        public Pedido (string cliente, double valorTotal, int quantidadeItens)
        {
            this.Cliente = cliente;
            this.ValorTotal = valorTotal;
            this.QuantidadeItens = quantidadeItens;            
        }
    }

    public class NotaFiscal
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public DateTime Data { get; private set; }
        
        public NotaFiscal(string cliente, double valor, DateTime Data)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Data = Data;
        }

    }

    public interface ISAP
    {
        void Envia(NotaFiscal nf);
    }

    public class SAP
    {
        public void Envia(NotaFiscal nf)
        {
            //Envia NF para o SAP
        }
    }

    public interface INFDao
    {
        void Persiste(NotaFiscal nf);
    }

    public class NFDao : INFDao
    {
        public void Persiste(NotaFiscal nf)
        {
            //persiste NF
        }
    }
}
