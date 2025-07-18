using Microsoft.AspNetCore.Mvc;

namespace ForexGUI.Controllers
{
    public class UserDashboardController : Controller
    {
        public IActionResult UserDashboard()
        {
            return View();
        }
    }
}
