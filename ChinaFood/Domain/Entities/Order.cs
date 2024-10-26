namespace ChinaFood.Domain.Entities;

public class Order : EntityBase
{
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; } 
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public virtual List<OrderItem> Items { get; set; }
}

