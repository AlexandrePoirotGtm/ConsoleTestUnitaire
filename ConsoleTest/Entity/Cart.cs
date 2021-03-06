﻿using System.Collections.Generic;
using System.Linq;

namespace ConsoleTest
{
    public class Cart
    {
        public Cart()
        {
            Lines = new List<Line>();
        }

        public int ID { get; set; }
        public List<Line> Lines { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal GetTotal()
        {
            if (!Lines.Any())
            {
                return 0;
            }
            var totalLignes = Lines.Sum(x => x.Product.Price * x.Quantity);

            var ShippingCost = totalLignes >= 100 ? 0 : 10;
            return totalLignes + ShippingCost;
        }
    }
}
