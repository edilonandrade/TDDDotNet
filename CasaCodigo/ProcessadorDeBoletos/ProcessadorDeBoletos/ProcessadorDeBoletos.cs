using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessadorDeBoletos
{
    public class ProcessadorDeBoletos
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            double valorTotal = 0;

            foreach(var boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.Pagamentos.Add(pagamento);

                valorTotal += boleto.Valor;
            }

            if (valorTotal >= fatura.Valor)
            {
                fatura.Pago = true;
            }
        }
    }
}