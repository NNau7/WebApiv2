using Microsoft.AspNetCore.Mvc;

namespace WebApiv2.Controllers;

public class CategoryController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}