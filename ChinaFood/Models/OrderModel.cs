using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ChinaFood.Models;

public class OrderModel : BaseModel
{
    [Required]
    public int OrderId { get; set; }

    [Required]
    [DisplayName("Customer Name")]
    public string CustomerName { get; set; }

    [Required]
    [DisplayName("Customer Email")]
    public string CustomerEmail { get; set; }
    
    [Required]
    [DisplayName("Customer Phone")]
    public string CustomerPhone { get; set; }
    [Required]
    [DisplayName("Customer Address")]
    public string CustomerAddress { get; set; }

    [Required]
    [DisplayName("Order Details")]
    public string OrderDetails { get; set; }

    [Required]
    [DisplayName("Order Date")]
    public DateTime OrderDate { get; set; }

    [Required]
    [DisplayName("Total amount")]
    public decimal TotalAmount { get; set; }

    [Required]
    [DisplayName("Order items")]
    public List<CartItem> Items { get; set; }
}
