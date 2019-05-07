using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ExemploSiteCompra;

namespace TesteExemploSiteCompra
{
    [TestFixture]
    public class MairoPrecoItemTest
    {
        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio() {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            MaiorPrecoItem algoritimo = new MaiorPrecoItem();

            double valor = algoritimo.Encontra(carrinho);

            Assert.AreEqual(0.0, valor, 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));

            MaiorPrecoItem algoritimo = new MaiorPrecoItem();

            double valor = algoritimo.Encontra(carrinho);

            Assert.AreEqual(900.0, valor, 0.0001);
        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));

            MaiorPrecoItem algoritimo = new MaiorPrecoItem();
            double valor = algoritimo.Encontra(carrinho);

            Assert.AreEqual(1500.0, valor, 0.0001);
        }
    }
}