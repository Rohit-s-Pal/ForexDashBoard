using ForexGUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForexAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LoginViewModel model)
        {
            if (model.EmailId == "test@example.com" && model.Password == "12345")
            {
                return Ok(new
                {
                    success = true,

                    redirectUrl = "/AdminDashboard/AdminDashboard"
                });
            }
            return Unauthorized(new { success = false, message = "Invalid username or password" });
        }
    }
}
