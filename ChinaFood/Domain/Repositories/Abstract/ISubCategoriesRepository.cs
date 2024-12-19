using ChinaFood.Domain.Entities;
using ChinaFood.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ChinaFood.Domain.Repositories.Abstract
{
    public interface ISubCategoriesRepository
    {
        IQueryable<SubCategory> GetAll();
        IQueryable<SubCategoryModel> GetAllByCulture(CultureInfo culture);
        IQueryable<SubCategory> GetAllByType(DishType type);
        IQueryable<SubCategoryModel> GetAllByTypeAndCulture(CultureInfo culture, DishType type);
        SubCategory GetById(Guid id);
        SubCategoryModel GetByIdAndCulture(Guid id, CultureInfo culture);
        void Save(SubCategory entity);
        void Delete(Guid id);
        List<string> GetDataNames();
    }
}
