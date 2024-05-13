using CMS.Common.Interfaces;

namespace CMS.BL
{
    public class Customer : EntityBase, ILoggable, IEmailable
    {
        public Customer() : this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerID { get; set; }
        public int CustomerType { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        return fullName = FirstName + "," + fullName;
                    }
                    return fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int instanceCounter { get; set; }

        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
                return false;
            if (string.IsNullOrWhiteSpace(LastName))
                return false;
            return true;
        }

        private string Addresses()
        {
            string result = "";
            int i = 1;

            foreach (Address address in AddressList)
            {
                result += $"\nAddress:{i++}= Address type:{address.AddressType}, StreetLine_1 :{address.StreetLine_1}, StreetLine_2: {address.StreetLine_2}, PostalCode: {address.PostalCode}, Country: {address.Country}";
            }
            return result;
        }
        public string Log()
        {
            return $"\nCustomer ID: {CustomerID}, Customer type: {CustomerType}, FullName: {FullName}, Email: {Email}, {Addresses()}";
        }

        public string Send(string sendTo)
        {
            return Email = sendTo;
        }
    }
}
