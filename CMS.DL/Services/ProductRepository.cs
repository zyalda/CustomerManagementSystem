using CMS.BL;

namespace CMS.DL.Services
{
    public class ProductRepository
    {
        public ProductRepository()
        {

        }
        public bool Save(Product product)
        {
            bool success;
            if (product.IsValid)
            {
                success = true;
            }
            else
            {
                success = false;
            }
            return success;
        }
    }
}
