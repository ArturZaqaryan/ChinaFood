using ChinaFood.Domain.Entities;

namespace ChinaFood.Models
{
    public class SearchModel
    {
        /// <summary>
        /// Название блюда для поиска (частичное совпадение).
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Минимальная цена для фильтрации.
        /// </summary>
        public decimal? MinPrice { get; set; }

        /// <summary>
        /// Максимальная цена для фильтрации.
        /// </summary>
        public decimal? MaxPrice { get; set; }

        /// <summary>
        /// Тип блюда (перечисление DishType).
        /// </summary>
        public DishType? DishType { get; set; }

        /// <summary>
        /// Идентификатор подкатегории блюда.
        /// </summary>
        public Guid? SubCategoryId { get; set; }
    }
}
