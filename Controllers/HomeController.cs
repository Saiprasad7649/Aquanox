using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // This will use Views/Home/Index.cshtml
    }

    public IActionResult Contact()
    {
        return Content("Main Area → Home → Contact");
    }

    public IActionResult Privacy()
    {
        return Content("Main Area → Home → Privacy");
    }

    public IActionResult Terms()
    {
        return Content("Main Area → Home → Terms & Conditions");
    }

    public IActionResult Cookies()
    {
        return Content("Main Area → Home → Cookie Policies");
    }
}
