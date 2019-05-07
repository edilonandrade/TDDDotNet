using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploSiteCompra;
using NUnit.Framework;

namespace TesteExemploSiteCompra
{
    [TestFixture]
    public class TestaMaiorEMenor
    {
        static void Main(string[] args)
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));            
            carrinho.Adiciona(new Produto("Jogo de Pratos", 70.0));

            MaiorEMenor algoritimo = new MaiorEMenor();
            algoritimo.Encontra(carrinho);

            Console.WriteLine("O menor produto é " + algoritimo.Menor.Nome);
            Console.WriteLine("O maior produto é " + algoritimo.Maior.Nome);
            Console.ReadLine();
        }

        [Test]
        public void OrdemDecrescente()
        {

            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(new Produto("Jogo de Pratos", 70.0));

            MaiorEMenor algoritimo = new MaiorEMenor();
            algoritimo.Encontra(carrinho);
            
            Assert.AreEqual("Jogo de Pratos", algoritimo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritimo.Maior.Nome);
        }

        [Test]
        public void ApenasUmProduto()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", 450.0));

            MaiorEMenor algoritimo = new MaiorEMenor();
            algoritimo.Encontra(carrinho);

            Assert.AreEqual("Geladeira", algoritimo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritimo.Maior.Nome);
        }
    }
}
