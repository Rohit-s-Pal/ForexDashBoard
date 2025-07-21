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
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            if (string.IsNullOrEmpty(model.EmailId) || string.IsNullOrEmpty(model.Password))
            {
                return Json(new { success = false, message = "Email & Password are required" });
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5209/");
                var response = await client.PostAsJsonAsync("api/Login/Login", model);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<ApiResponse>();
                    if (result != null && result.success)
                    {
                        
                        return Json(new { success = true, redirectUrl = result.RedirectUrl });
                    }
                    else
                    {
                        return Json(new { success = false, message = result?.message ?? "Unknown error" });
                    }
                }
                else
                {
                    return Json(new { success = false, message = "API login failed" });
                }

            }

 
        }


    }
}
