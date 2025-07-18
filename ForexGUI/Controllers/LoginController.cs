using ForexGUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ForexGUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginViewModel model)
        {
            if (string.IsNullOrEmpty(model.EmailId) || string.IsNullOrEmpty(model.Password))
            {
                return Json(new { success = false, message = "Email & Password are required" });
            }

            // Dummy login check (replace with DB or Identity)
            if (model.EmailId == "test@example.com" && model.Password == "12345")
            {
                return Json(new { success = true, message = "Login successful", redirectUrl = Url.Action("UserDashboard", "UserDashboard") });
            }

            return Json(new { success = false, message = "Invalid Email or Password" });
        }


    }
}
