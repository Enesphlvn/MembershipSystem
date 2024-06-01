using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Core.ViewModels
{
    public class ResetPasswordViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Yeni şifre: ")]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Şifre tekrarı yanlış.")]
        [Required(ErrorMessage = "Şifre tekrarı alanı boş bırakılamaz.")]
        [Display(Name = "Yeni şifre tekrar: ")]
        public string PasswordConfirm { get; set; } = null!;
    }
}
