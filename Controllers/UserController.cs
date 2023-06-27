using Microsoft.AspNetCore.Mvc;
using NetCore.Models;
using NetCore.Services;

namespace NetCore.Controllers;

public class UserController : Controller
{
    public IActionResult Signup()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Signup(Users u)
    {
        UserService us =new UserService();
        us.Insert(u);
        return RedirectToAction("Login","Users");
    }

    public IActionResult Login()
    {
        return View();
    }

}
