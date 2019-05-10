using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using ExemploSiteCompra;

namespace TesteExemploSiteCompra
{
    [TestFixture]
    public class CopiadoraTest
    {
        [Test]
        public void DeveLerEEnviarOConteudoLido()
        {
            var e = new Mock<IEscritor>();
            var l = new Mock<ILeitor>();

            l.Setup(r => r.TemCaracteres()).Returns(new Queue<bool>(new[] { true, false }).Dequeue);

            l.Setup(t => t.LeCaracteres()).Returns("Mauricio");

            Copiadora c = new Copiadora(l.Object, e.Object);

            c.Copiar();
            e.Verify(t => t.Escreve("Mauricio"));
        }
    }
}
