namespace ChinaFood.Domain.Entities;

public class OrderItem : EntityBase
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPrice => Quantity * Price; 
    public Guid OrderId { get; set; }
    public virtual Order Order { get; set; }
    public Guid DishId { get; set; }
    public virtual Dish Dish { get; set; }
}
