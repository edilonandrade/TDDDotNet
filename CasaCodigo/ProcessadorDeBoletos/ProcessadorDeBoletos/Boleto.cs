using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessadorDeBoletos
{
    public class Boleto
    {
        private double _valor;

        public Boleto(double valor)
        {
            this._valor = valor;
        }

        public double Valor { get { return _valor; } set { _valor = value; } }
    }
}
