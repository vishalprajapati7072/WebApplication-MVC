using Microsoft.AspNetCore.Mvc;

namespace WebApplication_MVC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
