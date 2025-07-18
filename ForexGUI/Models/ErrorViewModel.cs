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

}
