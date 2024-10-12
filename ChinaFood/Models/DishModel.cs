using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ChinaFood.Models;

public class DishModel : BaseModel
{
    [Required]
    [DisplayName("Column")]
    public decimal Price { get; set; }
}
