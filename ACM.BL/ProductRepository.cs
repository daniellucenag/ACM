using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        public Product Retrieve(int id)
        {
            Product product = new Product(id);

            if (id == 1)
            {
                product.Description = "Test";
                product.CurrentPrice = 18.60m;
                product.Name = "Test";
            }

            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}