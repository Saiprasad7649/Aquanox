using Microsoft.AspNetCore.Mvc;

public class MembershipController : Controller
{
    public IActionResult List(string id = "All")
    {
        return Content($"Main Area → Membership → List: {id}");
    }
}
