using Microsoft.AspNetCore.Mvc;

public class ClassController : Controller
{
    public IActionResult List(string id = "All")
    {
        return Content($"Main Area → Class → List: {id}");
    }
}
