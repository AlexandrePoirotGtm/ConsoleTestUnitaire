using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class Line
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public void Valider()
        {
            if(Quantity < 0)
            throw new Exception("Quantité doit être positive");

            if (Product == null)
                throw new Exception("Produit doit être renseigné");
        }
    }
}
