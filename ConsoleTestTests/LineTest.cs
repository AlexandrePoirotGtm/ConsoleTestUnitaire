using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleTest;

namespace ConsoleTestTests
{
    [TestClass]
    public class LineTest
    {
        [TestMethod]
        public void ValiderQuantitePositive()
        {
            var line = new Line
            {
                Product = new Product(),
                Quantity = -1
            };

            var exception = Assert.ThrowsException<Exception>(() => line.Valider());
            Assert.AreEqual("Quantité doit être positive", exception.Message);
        }

        [TestMethod]
        public void ValiderProduitRensigne()
        {
            var line = new Line
            {
                Product = null,
                Quantity = 1
            };

            var exception = Assert.ThrowsException<Exception>(() => line.Valider());
            Assert.AreEqual("Produit doit être renseigné", exception.Message);
        }
    }
}
