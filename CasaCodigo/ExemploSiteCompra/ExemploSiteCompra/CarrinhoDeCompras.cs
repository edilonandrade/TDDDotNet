using System;
using System.Collections.Generic;

namespace ExemploSiteCompra
{
    public class CarrinhoDeCompras
    {
        public List<Produto> Produtos { get; internal set; }
        public IList<Item> Itens { get; private set; }

        public CarrinhoDeCompras() {
            Produtos = new List<Produto>();
            this.Itens = new List<Item>();
        }
        public void Adiciona(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void Adiciona(Item item)
        {
            this.Itens.Add(item);
        }
    }
}