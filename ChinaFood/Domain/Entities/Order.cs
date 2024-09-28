namespace ChinaFood.Domain.Entities
{
    public class Order : EntityBase
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; } 
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class OrderItem : EntityBase
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice => Quantity * Price;
    }
}
