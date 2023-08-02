using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Hotelier.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage="Kullanıcı Adınızı Giriniz!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifrenizi Giriniz!")]
        public string Password { get; set; }
    }
}
