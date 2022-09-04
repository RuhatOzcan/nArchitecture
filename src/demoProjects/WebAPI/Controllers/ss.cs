using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

public class ss : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}