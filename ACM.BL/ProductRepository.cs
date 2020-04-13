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
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //Call Insert
                    }
                    else
                    {
                        //Call Update
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}