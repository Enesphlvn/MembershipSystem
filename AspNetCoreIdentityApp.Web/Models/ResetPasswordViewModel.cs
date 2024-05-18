using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.Models
{
    public class ResetPasswordViewModel
    {
        [EmailAddress(ErrorMessage = "Email formatı yanlış.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }


    }
}
