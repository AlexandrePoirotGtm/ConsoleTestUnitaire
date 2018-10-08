using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price
        {
            get { return this.Price; }
            set
            {
                if (value <= 0)
                    throw new Exception("Prix ne peut pas être négatif");

                Price = value;
            }
        }

        public void Valider()
        {
            if (Price <= 0)
                throw new Exception("Prix ne peut pas être négatif");
            
            if(string.IsNullOrEmpty(Name))
                throw new Exception("Nom est requis");
        }
    }
}
