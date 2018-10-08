using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class Product
    {
        public decimal price;
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new Exception("Prix doit être > 0");

                price = value;
            }
        }

        public void Valider()
        {
            if (Price <= 0)
                throw new Exception("Prix doit être > 0");
            
            if(string.IsNullOrWhiteSpace(Name))
                throw new Exception("Nom est requis");
        }
    }
}
