using ChinaFood.Domain;
using ChinaFood.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ChinaFood.Areas.Admin.Controllers;

[Area("Admin")]
public class DishesController(DataManager dataManager, IWebHostEnvironment hostingEnvironment) : Controller
{
    private readonly DataManager dataManager = dataManager;
    private readonly IWebHostEnvironment hostingEnvironment = hostingEnvironment;


    // GET: DishesController/Edit/5
    public IActionResult Edit(Guid id)
    {
        var entity = id == default ? new Dish() : dataManager.Dishes.GetById(id);
        ViewBag.SubCategories = dataManager.SubCategories.GetAll().Select(r => new SelectListItem { Value = r.Id.ToString(), Text = r.TitleEn, Selected = entity.SubCategoryId == r.Id }).ToList();
        return View(entity);
    }

    // POST: CitiesController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Dish model, IFormFile titleImageFile, string defaultImagePath, string subCategory)
    {
        if (ModelState.IsValid)
        {
            if (titleImageFile != null)
            {
                switch (model.DishType)
                {
                    case DishType.China:
                        model.TitleImagePath = "images/China/" + titleImageFile.FileName;
                        break;
                    case DishType.Japan:
                        model.TitleImagePath = "images/Japan/" + titleImageFile.FileName;
                        break;
                    case DishType.Drink:
                        model.TitleImagePath = "images/Drink/" + titleImageFile.FileName;
                        break;
                    default:
                        break;
                }
                using var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, model.TitleImagePath), FileMode.Create);
                titleImageFile.CopyTo(stream);
            }
            else
            {
                model.TitleImagePath = defaultImagePath;
            }

            model.SubCategoryId = Guid.Parse(subCategory);

            // Проверяем, что подкатегория соответствует категории
            var subCategoryEntity = dataManager.SubCategories.GetById(model.SubCategoryId);

            if (subCategoryEntity == null || subCategoryEntity.DishType != model.DishType)
            {
                ModelState.AddModelError("", "Invalid subcategory for the selected dish type.");
                return View(model);
            }

            dataManager.Dishes.Save(model);
            return RedirectToAction($"Read", "Home");
        }
        return View(model);
    }


    // POST: CitiesController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(Guid id)
    {
        dataManager.Dishes.Delete(id);
        return RedirectToAction("Read", "Home");
    }
}
