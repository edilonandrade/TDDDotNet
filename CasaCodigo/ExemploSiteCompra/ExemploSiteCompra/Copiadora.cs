using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSiteCompra
{
    public class Copiadora
    {
        private ILeitor leitor;
        private IEscritor escritor;

       
        public Copiadora(ILeitor leitor, IEscritor escritor)
        {
            this.leitor = leitor;
            this.escritor = escritor;
        }

        public void Copiar()
        { while (leitor.TemCaracteres())
            {
                escritor.Escreve(leitor.LeCaracteres());
            }
        }
    }
    public interface IEscritor
    {
        void Escreve(string conteudo);
    }

    public interface ILeitor
    {
        string LeCaracteres();
        bool TemCaracteres();
    }

    internal class EscritorPelaSerial : IEscritor
    {
        public void Escreve(string conteudo)
        {
            Console.WriteLine(conteudo);
        }
    }

    internal class LeitorDeXML : ILeitor
    {
        public string LeCaracteres()
        {
            return "Mauricio";
        }

        public bool TemCaracteres()
        {
            return false;
        }
    }
}
