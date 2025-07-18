namespace ForexGUI.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class LoginViewModel
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
    }

    public class ApiResponse
    {
        public bool success { get; set; }
        public string? RedirectUrl { get; set; }
        public string? message { get; set; }
        public string? Token { get; set; }
    }


}
