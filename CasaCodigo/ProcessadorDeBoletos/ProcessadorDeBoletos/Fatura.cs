using System.Collections.Generic;

namespace ProcessadorDeBoletos
{
    public class Fatura
    {
        private string cliente;
        private double valor;
        private List<Pagamento> objPagamentos;

        public Fatura(string cliente, double valor)
        {
            this.cliente = cliente;
            this.valor = valor;
            objPagamentos = new List<Pagamento>();
        }

        public List<Pagamento> Pagamentos
        {
            get
            {
                return objPagamentos;
            }

            set { objPagamentos = value; }
        }

        public bool Pago { get; set; }
        public double Valor { get { return valor; } set { valor = value; } }
    }
}