using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessadorDeBoletos
{
    public class Pagamento
    {
        private double _valor;
        private MeioDePagamento bOLETO;

        public Pagamento(double valor, MeioDePagamento bOLETO)
        {
            this._valor = valor;
            this.bOLETO = bOLETO;
        }

        public double Valor { get { return _valor; }  set { _valor = value; } }
    }
}
