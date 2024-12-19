namespace ChinaFood.Models;

public class CartItem
{
    public Guid ProductId { get; set; }
    public string Title { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
