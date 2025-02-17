namespace OrderProcessingApp.Models
{
    public class Order
    {
        public string orderId { get; set; }

        public int OrderTotal { get; set; }

        public string CustomerType { get; set; }
    }

    public enum CustomerType
    {
        Loyal,
        New
    }
}