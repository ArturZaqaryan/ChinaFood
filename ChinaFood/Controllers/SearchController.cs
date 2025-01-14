﻿using ChinaFood.Domain;
using ChinaFood.Domain.Entities;
using ChinaFood.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace ChinaFood.Controllers;

public class SearchController(DataManager dataManager) : Controller
{
    private readonly DataManager dataManager = dataManager;

    [HttpGet]
    public IActionResult Search(SearchModel model)
    {
        var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
        var culture = rqf.RequestCulture.Culture;

        ViewBag.Culture = culture;
        Dictionary<DishType, Dictionary<SubCategoryModel, List<DishModel>>> result = [];
        
        var dishes = dataManager.Dishes.GetAllByCulture(culture).ToList();

        if (!string.IsNullOrWhiteSpace(model.Destination))
        {
            dishes = dishes.Where(d => d.Title.Contains(model.Destination, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        //if (model.MinPrice.HasValue)
        //{
        //    dishes = dishes.Where(d => d.Price >= model.MinPrice.Value).ToList();
        //}

        //if (model.MaxPrice.HasValue)
        //{
        //    dishes = dishes.Where(d => d.Price <= model.MaxPrice.Value).ToList();
        //}

        if (model.DishType.HasValue)
        {
            result.Add(model.DishType.Value, []);
            dishes = dishes.Where(d => d.DishType == model.DishType.Value).ToList();
        }
        if (model.SubCategoryId.HasValue)
        {
            var subCategory = dataManager.SubCategories.GetByIdAndCulture(model.SubCategoryId.Value, culture);

            if(model.DishType.Value == subCategory.DishType)
            {
                result[subCategory.DishType].Add(subCategory, []);
                dishes = dishes.Where(d => d.SubCategoryId == model.SubCategoryId.Value).ToList();
            }
        }
        if (dishes.Count == 0)
        {
            ViewBag.Message = "Результаты поиска не найдены.";
        }

        foreach (var item in dishes)
        {
            result.TryAdd(item.DishType, []);

            var subCategoryModel = dataManager.SubCategories.GetByIdAndCulture(item.SubCategoryId, culture);
            result[item.DishType].TryAdd(subCategoryModel, []);

            result[item.DishType][subCategoryModel].Add(item);
        }

        return View(result);
    }

    [HttpGet]
    public IActionResult GetSubCategoriesByDishType(string dishType)
    {
        var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
        var culture = rqf.RequestCulture.Culture;

        var subCategories = dataManager.SubCategories.GetAllByTypeAndCulture(culture, Enum.Parse<DishType>(dishType)); // Логика получения подкатегорий
        return Json(subCategories.Select(sc => new { sc.Id, sc.Title }));
    }
}
