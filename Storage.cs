using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaLess1
{
   public class Storage
    {
        public List<Product> products = new List<Product>();
        public Storage( params  Product[] products)
        {
            foreach (var item in products)
            {
                this.products.Add(item);
            }
        }
        public Product this[int i]
        {
            get
            {
                return products[i];
            }
        }
        public void UserDialog()
        {

        }
      dfg

    }
}
