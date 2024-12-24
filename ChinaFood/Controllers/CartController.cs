using ChinaFood.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using System.Text.Json;
using ChinaFood.Domain;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using ChinaFood.Service;
using Microsoft.Extensions.Options;

namespace ChinaFood.Controllers;

public class CartController(DataManager dataManager) : Controller
{
    private readonly DataManager dataManager = dataManager;
    [HttpPost]
    public IActionResult AddToCart(Guid productId, string title, decimal price, int quantity)
    {
        var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? [];

        var item = cart.FirstOrDefault(x => x.ProductId == productId);
        if (item != null)
        {
            item.Quantity += quantity;
        }
        else
        {
            cart.Add(new CartItem { ProductId = productId, Title = title, Price = price, Quantity = quantity });
        }

        HttpContext.Session.Set("Cart", cart);
        return Json(new { success = true, message = "Product added to cart." });
    }

    [HttpPost]
    public IActionResult Checkout(string name, string email, string phone, string address)
    {
        var cart = HttpContext.Session.Get<List<CartItem>>("Cart");
        if (cart == null || cart.Count == 0)
        {
            return Json(new { success = false, message = "Cart is empty." });
        }

        // Отправка Email (можно использовать уже написанный метод SendOrderEmail)
        try
        {
            var order = new OrderModel
            {
                CustomerEmail = email,
                Items = cart,
                CustomerName = name,
                CustomerPhone = phone,
                CustomerAddress = address
            };

            SendOrderEmail(order);
            SendEmailToOwner(order);
            HttpContext.Session.Remove("Cart"); // Очистить корзину
            return Json(new { success = true, message = "Order placed successfully." });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = $"Error: {ex.Message}" });
        }
    }

    public IActionResult Cart()
    {
        var requestCultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
        var currentCulture = requestCultureFeature?.RequestCulture.Culture.Name;
        var cultureInfo = CultureInfo.GetCultureInfo(currentCulture);
        var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? [];
        List<(CartItem, DishModel)> model = [];
        foreach (var item in cart)
        {
            model.Add((item, dataManager.Dishes.GetByIdAndCulture(item.ProductId, cultureInfo)));
        }
        return View(model);
    }

    private static void SendOrderEmail(OrderModel order)
    {
        var fromAddress = new MailAddress(Config.CompanyEmail, Config.CompanyName);
        var toAddress = new MailAddress(order.CustomerEmail);
        string fromPassword = Config.CompanyEmailPassword;
        const string subject = "Ձեր պատվերն ընդունված է";
        var body = $"Շնորհակալություն ենք հայտնում մեր ծառայություններից օգտվելու համար!\n\n" +
                   $"Պատվերի մանրամասները:\n" +
                   string.Join("\n", order.Items.Select(item => $"{item.Title} - {item.Quantity} x {item.Price}֏")) +
                   $"\n\nԸնդհանուր: {order.Items.Sum(item => item.Price * item.Quantity)}֏";

        var smtp = new SmtpClient
        {
            Host = "smtp.mail.ru",        // Сервер Mail.ru
            Port = 587,                    // Порт для SSL
            EnableSsl = true,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        };

        using var message = new MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body
        };
        smtp.Send(message);
    }
    private static void SendEmailToOwner(OrderModel order)
    {
        var fromAddress = new MailAddress(Config.CompanyEmail, Config.CompanyName);
        var toAddress = new MailAddress(Config.CompanyEmail, Config.CompanyName);
        string fromPassword = Config.CompanyEmailPassword;
        const string subject = "Նոր պատվեր";
        var body = $"{order.CustomerName}\n\n" +
                   $"{order.CustomerEmail}\n\n" +
                   $"{order.CustomerPhone}\n\n" +
                   $"{order.CustomerAddress}\n\n" +
                   $"Պատվերի մանրամասները՝\n" +
                   string.Join("\n", order.Items.Select(item => $"{item.Title} - {item.Quantity} x {item.Price}֏")) +
                   $"\n\nԸնդհանուր: {order.Items.Sum(item => item.Price * item.Quantity)}֏";

        var smtp = new SmtpClient
        {
            Host = "smtp.mail.ru",        // Сервер Mail.ru
            Port = 587,                    // Порт для SSL
            EnableSsl = true,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        };

        using var message = new MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body
        };
        smtp.Send(message);
    }
    public IActionResult GetCartCount()
    {
        var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();
        int itemCount = cart.Sum(item => item.Quantity);
        return Json(new { itemCount });
    }

    [HttpPost]
    public IActionResult UpdateCartItem(Guid productId, int quantity)
    {
        var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();

        var item = cart.FirstOrDefault(x => x.ProductId == productId);
        if (item != null)
        {
            if (quantity > 0)
            {
                item.Quantity = quantity;
            }
            else
            {
                cart.Remove(item); // Удалить, если количество <= 0
            }
        }

        HttpContext.Session.Set("Cart", cart);
        return Json(new { success = true, cartTotal = cart.Sum(x => x.Price * x.Quantity) });
    }

    [HttpPost]
    public IActionResult RemoveCartItem(Guid productId)
    {
        var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();

        var item = cart.FirstOrDefault(x => x.ProductId == productId);
        if (item != null)
        {
            cart.Remove(item);
        }

        HttpContext.Session.Set("Cart", cart);
        return Json(new { success = true, cartTotal = cart.Sum(x => x.Price * x.Quantity) });
    }

    [HttpGet]
    public IActionResult GetCartItems()
    {
        var cart = HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();

        var cartViewModel = cart.Select(item => new
        {
            item.ProductId,
            item.Title,
            item.Price,
            item.Quantity,
            Total = item.Price * item.Quantity
        });

        return Json(new { success = true, items = cartViewModel, cartTotal = cart.Sum(x => x.Price * x.Quantity) });
    }
}

public static class SessionExtensions
{
    public static void Set<T>(this ISession session, string key, T value)
    {
        session.SetString(key, JsonSerializer.Serialize(value));
    }

    public static T? Get<T>(this ISession session, string key)
    {
        var value = session.GetString(key);
        return value == null ? default : JsonSerializer.Deserialize<T>(value);
    }
}
