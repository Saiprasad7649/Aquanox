using Microsoft.AspNetCore.Mvc;

namespace Aquanox.Controllers
{
    public class ClubController : Controller
    {
        // This endpoint handles GET /Club/List
        public IActionResult List(string id = "All")
        {
            return Content($"Main Area → Club → List: {id}");
        }
    }
}
