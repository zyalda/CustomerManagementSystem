namespace CMS.BL
{
    public class OrderItem
    {
        public OrderItem() : this(0)
        {

        }
        public OrderItem(int orderItemID)
        {
            OrderItemID = orderItemID;

        }
        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public Order RetrieveCustomer(int orderItemID)
        {
            return new Order();
        }

        public List<Order> RetrieveAllOrder()
        {
            return new List<Order>();
        }
        public bool Save()
        {
            return true;
        }

    }
}
