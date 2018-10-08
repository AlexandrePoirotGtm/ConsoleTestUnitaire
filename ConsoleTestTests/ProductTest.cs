using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleTest;

namespace ConsoleTestTests
{
    [TestClass]
    public class ProductTest
    {
        [DataTestMethod]
        [DataRow("0")]
        [DataRow("-1")]
        public void ImpossibleDeMettrePrixInfOuEgal(string prix)
        {
            decimal prixx = decimal.Parse(prix);
            var expection = Assert.ThrowsException<Exception>(() => {
                var Product = new Product()
                {
                    Name = "test",
                    Price = prixx
                };
            });

            Assert.AreEqual("Prix doit être > 0", expection.Message);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public void ImpossibleDeMettreNomVide(string nom)
        {
            var expection = Assert.ThrowsException<Exception>(() => {
                var Product = new Product()
                {
                    Name = nom,
                    Price = 20
                };
                Product.Valider();
            });

            Assert.AreEqual("Nom est requis", expection.Message);
        }
    }
}
