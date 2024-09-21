using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ChinaFood.Models;

public class Dish : BaseModel
{
    [Required]
    public int DishId { get; set; }

    [Required]
    [DisplayName("Name")]
    public string Name { get; set; }

    [DisplayName("Description")]
    public string Description { get; set; }

    [Required]
    [DisplayName("Column")]
    public decimal Price { get; set; }

    [DisplayName("Image Url")]
    public string ImageUrl { get; set; }
}
