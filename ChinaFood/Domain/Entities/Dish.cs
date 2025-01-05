namespace ChinaFood.Domain.Entities
{
    public enum DishType
    {
        China,
        Japan,
        Drink
    }
    public class Dish : EntityBase
    {
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public DishType DishType { get; set; }
        public Guid SubCategoryId { get; set; } // FK для подкатегории
        public virtual SubCategory SubCategory { get; set; } // Навигационное свойство
    }
}
