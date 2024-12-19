namespace ChinaFood.Domain.Entities
{
    public class SubCategory : EntityBase
    {
        public DishType DishType { get; set; } // Тип категории для фильтрации
    }
}
