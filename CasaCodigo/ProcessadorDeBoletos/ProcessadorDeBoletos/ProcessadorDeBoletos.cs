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
            Boleto boleto = boletos[0];

            Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
            fatura.Pagamentos.Add(pagamento);
        }
    }
}