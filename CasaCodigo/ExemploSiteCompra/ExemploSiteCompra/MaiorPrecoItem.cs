using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExemploSiteCompra
{
    public class MaiorPrecoItem
    {
        public double Encontra(CarrinhoDeCompras carrinho)
        {
            if (carrinho.Itens.Count.Equals(0)) return 0;

            double maior = carrinho.Itens[0].ValorTotal;
            foreach(var item in carrinho.Itens)
            {
                if (maior < item.ValorTotal)
                {
                    maior = item.ValorTotal;
                }
            }
            return maior;
        }
    }
}