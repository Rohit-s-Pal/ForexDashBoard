using Microsoft.AspNetCore.Mvc;

namespace ForexGUI.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult AdminDashboard()
        {
            return View();
        }
    }
}
