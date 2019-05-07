using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSiteCompra
{
    public class MaiorEMenor
    {
        public Produto Menor { get; private set; }
        public Produto Maior { get; private set; }

        public void Encontra(CarrinhoDeCompras carrinho)
        {
            foreach(Produto produto in carrinho.Produtos)
            {
                if (Menor == null || produto.Valor < Menor.Valor)
                {
                    Menor = produto;
                }
                if (Maior == null || produto.Valor > Maior.Valor)  {
                    Maior = produto;
                }
            }
        }
    }
}
