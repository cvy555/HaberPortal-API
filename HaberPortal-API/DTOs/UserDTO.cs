using System.ComponentModel.DataAnnotations;

namespace HaberPortal_API.DTOs
{
    public class UserRegisterDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string AdSoyad { get; set; }
    }

    public class UserLoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
