namespace HaberPortal_API.Models
{
    public class LoginModel
    {
        public string Identifier { get; set; } = string.Empty; // Email, Phone Number veya Username
        public string Password { get; set; } = string.Empty;
    }

}
