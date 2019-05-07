using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploSiteCompra;

namespace TesteExemploSiteCompra
{
    public class CarrinhoDeComprasBuilder
    {
        public CarrinhoDeCompras carrinho;

        public CarrinhoDeComprasBuilder()
        {
            this.carrinho = new CarrinhoDeCompras();
        }

        public CarrinhoDeComprasBuilder ComItens(double[] valores)
        {
            foreach (double valor in valores) {
                carrinho.Adiciona(new Item("Item com valor " + valor.ToString(), 1, valor));
            }
            return this;
        }

        public CarrinhoDeCompras Cria()
        {
            return carrinho;
        }
    }
}
