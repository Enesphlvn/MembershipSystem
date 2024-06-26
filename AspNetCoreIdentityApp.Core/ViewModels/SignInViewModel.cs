﻿using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Core.ViewModels
{ 
    public class SignInViewModel
    {
        [EmailAddress(ErrorMessage = "Email formatı yanlış.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email: ")]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre: ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
        public string Password { get; set; } = null!;

        [Display(Name = "Beni Hatırla ")]
        public bool RememberMe { get; set; }
    }
}
