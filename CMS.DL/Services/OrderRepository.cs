using CMS.BL;

namespace CMS.DL.Services
{
    public class OrderRepository
    {
        public OrderRepository()
        {
            ShippingAddress = new AddressRepository();
            CustomerRepo = new CustomerRepository();
        }

        public AddressRepository ShippingAddress { get; set; }
        public CustomerRepository CustomerRepo { get; set; }

        public List<Order> RetrieveAllOrders()
        {
            return new List<Order>();
        }

        public Order RetrieveOrder(int orderId)
        {
            Address addresses = new Address();

            Customer customer = new Customer();
            Order singleOrder = new Order(1);

            if (orderId == 1)
            {
                singleOrder.CustomerID = customer.CustomerID;
                singleOrder.ShippingAddressID = addresses.AddressID;
                singleOrder.OrderDate = DateTime.Today;
            }
            return singleOrder;
        }
    }
}
