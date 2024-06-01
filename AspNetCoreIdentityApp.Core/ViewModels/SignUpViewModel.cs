using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Core.ViewModels
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı alanı boş bırakılamaz")]
        [Display(Name = "Kullanıcı adı: ")]
        public string UserName { get; set; } = null!;

        [EmailAddress(ErrorMessage ="Email formatı yanlış.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email: ")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Telefon numarası alanı boş bırakılamaz.")]
        [Display(Name = "Telefon: ")]
        public string Phone { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre: ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Şifre tekrarı yanlış.")]
        [Required(ErrorMessage = "Şifre tekrarı alanı boş bırakılamaz.")]
        [Display(Name = "Şifre tekrar: ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
        public string PasswordConfirm { get; set; } = null!;
    }
}
