using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartamentoPessoal
{

    public class Cargo
    {
        public Cargo DESENVOLVEDOR
        {
            get { return new Cargo(new DezOuVintePorCento()); }
        }

        public Cargo DBA
        {
            get { return new Cargo(new QuinzeOuVinteCincoPorCento()); }
        }

        public Cargo TESTADOR
        {
            get { return new Cargo(new QuinzeOuVinteCincoPorCento()); }
        }

        public IRegraCalculo Regra { get; private set; }

        private Cargo(IRegraCalculo regra)
        {
            this.Regra = regra;
        }

        public Cargo()
        {

        }
    }
}
