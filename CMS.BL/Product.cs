using CMS.Common;

namespace CMS.BL
{
    public class Product : EntityBase
    {
        public Product() : this(0)
        {

        }
        public Product(int productId)
        {
            ProductID = productId;

        }
        public int ProductID { get; private set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

        public string Log() => $"prodName:{_productName}, productDescription: {ProductDescription}, price{CurrentPrice}";

    }
}
