using ChinaFood.Domain;
using ChinaFood.Domain.Entities;
using ChinaFood.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ChinaFood.Controllers;

public class HomeController(ILogger<HomeController> logger, DataManager dataManager) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    private readonly DataManager dataManager = dataManager;

    public IActionResult Index()
    {
        var requestCultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
        var currentCulture = requestCultureFeature?.RequestCulture.Culture.Name;
        var cultureInfo = CultureInfo.GetCultureInfo(currentCulture);

        ViewBag.ChinesseDishes = dataManager.Dishes.GetAllByTypeAndCulture(cultureInfo, DishType.China).ToList();
        ViewBag.JapanesseDishes = dataManager.Dishes.GetAllByTypeAndCulture(cultureInfo, DishType.Japan).ToList();
        ViewBag.Drinks = dataManager.Dishes.GetAllByTypeAndCulture(cultureInfo, DishType.Drink).ToList();

        // Получение подкатегорий из базы данных
        var subCategories = dataManager.SubCategories.GetAllByCulture(cultureInfo)
            .ToList();

        // Передача данных в ViewBag
        ViewBag.SubCategories = subCategories;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult SetLanguage(string culture, string returnUrl)
    {
        Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
        );

        return LocalRedirect(returnUrl);
    }

    [HttpPost]
    public IActionResult SingleDish(Guid id)
    {
        var requestCultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
        var currentCulture = requestCultureFeature?.RequestCulture.Culture.Name;
        var cultureInfo = CultureInfo.GetCultureInfo(currentCulture);

        var dish = dataManager.Dishes.GetByIdAndCulture(id, cultureInfo); // Загрузить блюдо из базы данных

        return View(dish); // Отобразить или обработать
    }
}
