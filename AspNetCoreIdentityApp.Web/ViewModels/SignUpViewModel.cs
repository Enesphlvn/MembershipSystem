using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {
        [Display(Name = "Kullanıcı adı: ")]
        public string UserName { get; set; }

        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Display(Name = "Telefon: ")]
        public string Phone { get; set; }

        [Display(Name = "Şifre: ")]
        public string Password { get; set; }

        [Display(Name = "Şifre tekrar: ")]
        public string PasswordConfirm { get; set; }
    }
}
