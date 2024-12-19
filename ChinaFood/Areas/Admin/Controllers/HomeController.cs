using ChinaFood.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ChinaFood.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController(DataManager dataManager) : Controller
{
    private readonly DataManager dataManager = dataManager;

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Read()
    {
        return View(dataManager);
    }

    //[HttpPost]
    //public IActionResult Read(string table)
    //{
    //    ViewBag.SelectedTable = table;
    //    return View(dataManager);
    //}

    [HttpGet]
    public IActionResult Read(string table)
    {
        ViewBag.SelectedTable = table;
        return View(dataManager);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create(string table)
    {
        ViewBag.SelectedTable = table;
        return View(dataManager);
    }
}
