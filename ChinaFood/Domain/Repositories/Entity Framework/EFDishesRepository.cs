using ChinaFood.Domain.Entities;
using ChinaFood.Domain.Repositories.Abstract;
using ChinaFood.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace ChinaFood.Domain.Repositories.Entity_Framework
{
    public class EFDishesRepository(AppDbContext context) : IDishesRepository
    {
        private readonly AppDbContext context = context;

        public IQueryable<Dish> GetAll()
        {
            return context.Dishes;
        }

        public IQueryable<DishModel> GetAllByCulture(CultureInfo culture)
        {
            if (culture.Name == "en-US")
            {
                return context.Dishes.Select(dish =>
                        new DishModel
                        {
                            Title = dish.TitleEn,
                            Subtitle = dish.SubtitleEn,
                            Text = dish.TextEn,
                            DateAdded = dish.DateAdded,
                            Id = dish.Id,
                            Price = dish.Price,
                            MetaDescription = dish.MetaDescription,
                            MetaKeywords = dish.MetaKeywords,
                            MetaTitle = dish.MetaTitle,
                            TitleImagePath = dish.TitleImagePath
                        });
            }
            else if (culture.Name == "ru-RU")
            {
                return context.Dishes.Select(dish =>
                        new DishModel
                        {
                            Title = dish.TitleRu,
                            Subtitle = dish.SubtitleRu,
                            Text = dish.TextRu,
                            DateAdded = dish.DateAdded,
                            Id = dish.Id,
                            Price = dish.Price,
                            MetaDescription = dish.MetaDescription,
                            MetaKeywords = dish.MetaKeywords,
                            MetaTitle = dish.MetaTitle,
                            TitleImagePath = dish.TitleImagePath
                        });
            }
            else
            {
                return context.Dishes.Select(dish =>
                        new DishModel
                        {
                            Title = dish.TitleArm,
                            Price = dish.Price,
                            Subtitle = dish.SubtitleArm,
                            Text = dish.TextArm,
                            DateAdded = dish.DateAdded,
                            Id = dish.Id,
                            MetaDescription = dish.MetaDescription,
                            MetaKeywords = dish.MetaKeywords,
                            MetaTitle = dish.MetaTitle,
                            TitleImagePath = dish.TitleImagePath
                        });
            }
        }

        public Dish GetById(Guid id)
        {
            return context.Dishes.FirstOrDefault(x => x.Id == id);
        }

        public DishModel GetByIdAndCulture(Guid id, CultureInfo culture)
        {
            var dish = context.Dishes.FirstOrDefault(c => c.Id == id);
            if (dish is null)
            {
                return null;
            }

            if (culture.Name == "en-US")
            {
                return new DishModel
                {
                    Id = dish.Id,
                    Price = dish.Price,
                    DateAdded = dish.DateAdded,
                    MetaDescription = dish.MetaDescription,
                    MetaKeywords = dish.MetaKeywords,
                    MetaTitle = dish.MetaTitle,
                    Subtitle = dish.SubtitleEn,
                    Text = dish.TextEn,
                    Title = dish.TitleEn,
                    TitleImagePath = dish.TitleImagePath
                };
            }
            else if (culture.Name == "ru-RU")
            {
                return  new DishModel
                        {
                            Title = dish.TitleRu,
                            Subtitle = dish.SubtitleRu,
                            Text = dish.TextRu,
                            DateAdded = dish.DateAdded,
                            Id = dish.Id,
                            Price = dish.Price,
                            MetaDescription = dish.MetaDescription,
                            MetaKeywords = dish.MetaKeywords,
                            MetaTitle = dish.MetaTitle,
                            TitleImagePath = dish.TitleImagePath
                        };
            }
            else
            {
                return new DishModel
                {
                    Id = dish.Id,
                    Price = dish.Price,
                    DateAdded = dish.DateAdded,
                    MetaDescription = dish.MetaDescription,
                    MetaKeywords = dish.MetaKeywords,
                    MetaTitle = dish.MetaTitle,
                    Subtitle = dish.SubtitleArm,
                    Text = dish.TextArm,
                    Title = dish.TitleArm,
                    TitleImagePath = dish.TitleImagePath
                };
            }
        }

        public void Save(Dish entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.Dishes.Remove(new Dish() { Id = id });
            context.SaveChanges();
        }
    }
}
