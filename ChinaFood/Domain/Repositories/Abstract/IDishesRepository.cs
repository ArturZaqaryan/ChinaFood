using ChinaFood.Domain.Entities;
using ChinaFood.Models;
using System.Globalization;

namespace ChinaFood.Domain.Repositories.Abstract
{
    public interface IDishesRepository
    {
        IQueryable<Dish> GetAll();
        IQueryable<DishModel> GetAllByCulture(CultureInfo culture);
        Dish GetById(Guid id);
        DishModel GetByIdAndCulture(Guid id, CultureInfo culture);
        void Save(Dish entity);
        void Delete(Guid id);
        List<string> GetDataNames();
    }
}
