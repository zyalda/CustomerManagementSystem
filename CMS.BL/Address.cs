namespace CMS.BL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressID)
        {
            AddressID = addressID;
        }
        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        public string AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string StreetLine_1 { get; set; }
        public string StreetLine_2 { get; set; }

        public bool IsValid()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;

            return isValid;
        }
    }
}
