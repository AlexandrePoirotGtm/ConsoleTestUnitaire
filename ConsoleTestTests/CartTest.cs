using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleTest;

namespace ConsoleTestTests
{
    [TestClass]
    public class CartTest
    {
        [TestMethod]
        public void CalculerPrixTotalQuandVide()
        {
            var panier = new Cart();
            Assert.AreEqual(0, panier.GetTotal());
        }

        [TestMethod]
        public void CalculerPrixTotalNoraml()
        {
            var panier = new Cart();
            panier.Lines.Add(new Line
            {
                Product = new Product
                {
                    Name = "Truite",
                    Price = 15
                },
                Quantity = 6
            });

            Assert.AreEqual(100,panier.GetTotal());
        }

        [TestMethod]
        public void FraiDePortOffer100()
        {
            var panier = new Cart();
            panier.Lines.Add(new Line
            {
                Product = new Product
                {
                    Name = "Truite",
                    Price = 20
                },
                Quantity = 5
            });

            Assert.AreEqual(100, panier.GetTotal());
        }
    }
}
