using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ExemploSiteCompra;
using System.Diagnostics;

namespace TesteExemploSiteCompra
{
    [TestFixture]
    public class MairoPrecoItemTest
    {
        private CarrinhoDeCompras carrinho;

        [SetUp]
        public void Inicializa() {
            this.carrinho = new CarrinhoDeCompras();
        }

        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio() {
            MaiorPrecoItem algoritimo = new MaiorPrecoItem();

            double valor = algoritimo.Encontra(carrinho);

            Assert.AreEqual(0.0, valor, 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
           carrinho.Adiciona(new Item("Geladeira", 1, 900.0));

            MaiorPrecoItem algoritimo = new MaiorPrecoItem();

            double valor = algoritimo.Encontra(carrinho);

            Assert.AreEqual(900.0, valor, 0.0001);
        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeComprasBuilder()
                .ComItens(new double[] { 900.0, 1500.0, 750.0})
                .Cria();

            //carrinho.Adiciona(new Item("Geladeira", 1, 900.0));
            //carrinho.Adiciona(new Item("Fogão", 1, 1500.0));
            //carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0));
            
            MaiorPrecoItem algoritimo = new MaiorPrecoItem();
            double valor = algoritimo.Encontra(carrinho);

            Assert.AreEqual(1500.0, valor, 0.0001);
        }
    }
}