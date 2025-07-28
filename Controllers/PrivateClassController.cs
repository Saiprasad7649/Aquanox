using Microsoft.AspNetCore.Mvc;

public class PrivateClassController : Controller
{
    public IActionResult List(string id = "All")
    {
        return Content($"Main Area → PrivateClass → List: {id}");
    }
}
