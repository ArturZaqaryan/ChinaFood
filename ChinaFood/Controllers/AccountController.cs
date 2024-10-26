using ChinaFood.Domain.Entities;
using ChinaFood.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ChinaFood.Controllers;


public class AccountController(UserManager<User> userMgr, SignInManager<User> signinMgr) : Controller
{
    private readonly UserManager<User> userManager = userMgr;
    private readonly SignInManager<User> signInManager = signinMgr;

    [AllowAnonymous]
    public IActionResult Login(string returnUrl)
    {
        ViewBag.returnUrl = returnUrl;
        return View(new LoginViewModel());
    }
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
    {
        if (ModelState.IsValid)
        {
            User user = await userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                await signInManager.SignOutAsync();
                Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    return Redirect(returnUrl ?? "/");
                }
            }
            ModelState.AddModelError(nameof(LoginViewModel.UserName), "wrong login or password");
        }
        return View(model);
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult AccessDenied(string returnUrl = null)
    {
        // workaround
        if (Request.Cookies["Identity.External"] != null)
        {
            return Redirect(returnUrl ?? "/");
        }
        return RedirectToAction(nameof(Login));

    }

    [Authorize]
    public async Task<IActionResult> Logout()
    {
        await signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
}
