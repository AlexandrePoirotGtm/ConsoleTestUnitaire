using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleTest;

namespace ConsoleTestTests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ImpossibleDeMettrePrixInfOuEgal()
        {
            var expection = Assert.ThrowsException<Exception>(() => {
                var Product = new Product()
                {
                    Name = "test",
                    Price = 0
                };
            });

            Assert.AreEqual("Prix Ne peut pas être négatif", expection.Message);
        }

        [TestMethod]
        public void ImpossibleDeMettreNomVide()
        {
            Assert.ThrowsException<Exception>(() => {
                var Product = new Product()
                {
                    Name = "",
                    Price = 20
                };
                Product.Valider();
            });
        }
    }
}
