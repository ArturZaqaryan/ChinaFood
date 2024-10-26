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
        public DishType DishType { get; set; }
    }
}
