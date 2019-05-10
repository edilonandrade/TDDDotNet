using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessadorDeBoletos;

namespace InterfaceTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessadorDeBoletos.ProcessadorDeBoletos processador = new ProcessadorDeBoletos.ProcessadorDeBoletos();

            Fatura fatura = new Fatura("Cliente", 150.0);

            Boleto b1 = new Boleto(150.0);

            IList<Boleto> boletos = new List<Boleto>() { b1 };

            processador.Processa(boletos, fatura);

            Console.WriteLine(fatura.Pagamentos[0].Valor.ToString());

            Console.ReadLine();
        }
    }
}
