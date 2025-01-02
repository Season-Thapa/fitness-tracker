using Microsoft.AspNetCore.Mvc;

namespace Pri.Ee.Web.Controllers
{
    public class WorkoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
