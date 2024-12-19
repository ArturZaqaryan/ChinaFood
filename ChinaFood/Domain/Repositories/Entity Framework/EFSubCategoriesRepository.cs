using ChinaFood.Domain.Entities;
using ChinaFood.Domain.Repositories.Abstract;
using ChinaFood.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace ChinaFood.Domain.Repositories.Entity_Framework;

public class EFSubCategoriesRepository(AppDbContext context) : ISubCategoriesRepository
{
    private readonly AppDbContext context = context;

    public IQueryable<SubCategory> GetAll()
    {
        return context.SubCategories;
    }

    public IQueryable<SubCategoryModel> GetAllByCulture(CultureInfo culture)
    {
        if (culture.Name == "en-US")
        {
            return context.SubCategories.Select(subCategory =>
                    new SubCategoryModel
                    {
                        Title = subCategory.TitleEn,
                        Subtitle = subCategory.SubtitleEn,
                        Text = subCategory.TextEn,
                        DateAdded = subCategory.DateAdded,
                        Id = subCategory.Id,
                        MetaDescription = subCategory.MetaDescription,
                        MetaKeywords = subCategory.MetaKeywords,
                        MetaTitle = subCategory.MetaTitle,
                        TitleImagePath = subCategory.TitleImagePath,
                        DishType = subCategory.DishType
                    });
        }
        else if (culture.Name == "ru-RU")
        {
            return context.SubCategories.Select(subCategory =>
                    new SubCategoryModel
                    {
                        Title = subCategory.TitleRu,
                        Subtitle = subCategory.SubtitleRu,
                        Text = subCategory.TextRu,
                        DateAdded = subCategory.DateAdded,
                        Id = subCategory.Id,
                        MetaDescription = subCategory.MetaDescription,
                        MetaKeywords = subCategory.MetaKeywords,
                        MetaTitle = subCategory.MetaTitle,
                        TitleImagePath = subCategory.TitleImagePath,
                        DishType = subCategory.DishType
                    });
        }
        else
        {
            return context.SubCategories.Select(subCategory =>
                    new SubCategoryModel
                    {
                        Title = subCategory.TitleArm,
                        Subtitle = subCategory.SubtitleArm,
                        Text = subCategory.TextArm,
                        DateAdded = subCategory.DateAdded,
                        Id = subCategory.Id,
                        MetaDescription = subCategory.MetaDescription,
                        MetaKeywords = subCategory.MetaKeywords,
                        MetaTitle = subCategory.MetaTitle,
                        TitleImagePath = subCategory.TitleImagePath,
                        DishType = subCategory.DishType
                    });
        }
    }
    public IQueryable<SubCategory> GetAllByType(DishType type)
    {
        return context.SubCategories.Where(subCategory => subCategory.DishType == type);
    }
    public IQueryable<SubCategoryModel> GetAllByTypeAndCulture(CultureInfo culture, DishType type)
    {
        if (culture.Name == "en-US")
        {
            return context.SubCategories.Where(subCategory => subCategory.DishType == type).Select(subCategory =>
                    new SubCategoryModel
                    {
                        Title = subCategory.TitleEn,
                        Subtitle = subCategory.SubtitleEn,
                        Text = subCategory.TextEn,
                        DateAdded = subCategory.DateAdded,
                        Id = subCategory.Id,
                        MetaDescription = subCategory.MetaDescription,
                        MetaKeywords = subCategory.MetaKeywords,
                        MetaTitle = subCategory.MetaTitle,
                        TitleImagePath = subCategory.TitleImagePath,
                        DishType = subCategory.DishType
                    });
        }
        else if (culture.Name == "ru-RU")
        {
            return context.SubCategories.Where(subCategory => subCategory.DishType == type).Select(subCategory =>
                    new SubCategoryModel
                    {
                        Title = subCategory.TitleRu,
                        Subtitle = subCategory.SubtitleRu,
                        Text = subCategory.TextRu,
                        DateAdded = subCategory.DateAdded,
                        Id = subCategory.Id,
                        MetaDescription = subCategory.MetaDescription,
                        MetaKeywords = subCategory.MetaKeywords,
                        MetaTitle = subCategory.MetaTitle,
                        TitleImagePath = subCategory.TitleImagePath,
                        DishType = subCategory.DishType
                    });
        }
        else
        {
            return context.SubCategories.Where(subCategory => subCategory.DishType == type).Select(subCategory =>
                    new SubCategoryModel
                    {
                        Title = subCategory.TitleArm,
                        Subtitle = subCategory.SubtitleArm,
                        Text = subCategory.TextArm,
                        DateAdded = subCategory.DateAdded,
                        Id = subCategory.Id,
                        MetaDescription = subCategory.MetaDescription,
                        MetaKeywords = subCategory.MetaKeywords,
                        MetaTitle = subCategory.MetaTitle,
                        TitleImagePath = subCategory.TitleImagePath,
                        DishType = subCategory.DishType
                    });
        }
    }
    public SubCategory GetById(Guid id)
    {
        return context.SubCategories.FirstOrDefault(x => x.Id == id);
    }

    public SubCategoryModel GetByIdAndCulture(Guid id, CultureInfo culture)
    {
        var subCategory = context.SubCategories.FirstOrDefault(c => c.Id == id);
        if (subCategory is null)
        {
            return null;
        }

        if (culture.Name == "en-US")
        {
            return new SubCategoryModel
            {
                Id = subCategory.Id,
                DateAdded = subCategory.DateAdded,
                MetaDescription = subCategory.MetaDescription,
                MetaKeywords = subCategory.MetaKeywords,
                MetaTitle = subCategory.MetaTitle,
                Subtitle = subCategory.SubtitleEn,
                Text = subCategory.TextEn,
                Title = subCategory.TitleEn,
                TitleImagePath = subCategory.TitleImagePath,
                DishType = subCategory.DishType
            };
        }
        else if (culture.Name == "ru-RU")
        {
            return new SubCategoryModel
            {
                Title = subCategory.TitleRu,
                Subtitle = subCategory.SubtitleRu,
                Text = subCategory.TextRu,
                DateAdded = subCategory.DateAdded,
                Id = subCategory.Id,
                MetaDescription = subCategory.MetaDescription,
                MetaKeywords = subCategory.MetaKeywords,
                MetaTitle = subCategory.MetaTitle,
                TitleImagePath = subCategory.TitleImagePath,
                DishType = subCategory.DishType
            };
        }
        else
        {
            return new SubCategoryModel
            {
                Id = subCategory.Id,
                DateAdded = subCategory.DateAdded,
                MetaDescription = subCategory.MetaDescription,
                MetaKeywords = subCategory.MetaKeywords,
                MetaTitle = subCategory.MetaTitle,
                Subtitle = subCategory.SubtitleArm,
                Text = subCategory.TextArm,
                Title = subCategory.TitleArm,
                TitleImagePath = subCategory.TitleImagePath,
                DishType = subCategory.DishType
            };
        }
    }

    public void Save(SubCategory entity)
    {
        if (entity.Id == default)
            context.Entry(entity).State = EntityState.Added;
        else
            context.Entry(entity).State = EntityState.Modified;
        context.SaveChanges();
    }

    public void Delete(Guid id)
    {
        context.SubCategories.Remove(new SubCategory() { Id = id });
        context.SaveChanges();
    }

    public List<string> GetDataNames()
    {
        var list = new List<string>() { "Title", "Subtitle", "Text", "Title image path", "Dish type", "Date added" };
        return list;
    }

    public List<string> GetData(SubCategory entity)
    {
        var list = new List<string>
            {
                entity.TitleEn.ToString(),
                entity.SubtitleEn?.ToString(),
                entity.TextEn?.ToString(),
                entity.TitleImagePath?.ToString(),
                entity.DishType.ToString(),
                entity.DateAdded.ToString()
            };

        return list;
    }
}
