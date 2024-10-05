using Microsoft.AspNetCore.Mvc;

namespace expenses_tracker.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}