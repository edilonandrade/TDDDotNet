using System;
using System.Collections.Generic;

namespace ExemploSiteCompra
{
    public class CarrinhoDeCompras
    {
        public List<Produto> Produtos { get; internal set; }

        public CarrinhoDeCompras() {
            Produtos = new List<Produto>();
        }
        public void Adiciona(Produto produto)
        {
            Produtos.Add(produto);
        }
    }
}