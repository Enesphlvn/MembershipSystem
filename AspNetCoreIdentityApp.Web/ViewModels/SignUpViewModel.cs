using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı alanı boş bırakılamaz")]
        [Display(Name = "Kullanıcı adı: ")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage ="Email formatı yanlış.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon numarası alanı boş bırakılamaz.")]
        [Display(Name = "Telefon: ")]
        public string Phone { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre: ")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Şifre tekrarı yanlış.")]
        [Required(ErrorMessage = "Şifre tekrarı alanı boş bırakılamaz.")]
        [Display(Name = "Şifre tekrar: ")]
        public string PasswordConfirm { get; set; }
    }
}
