using AspNetCoreIdentityApp.Web.Models;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentityApp.Web.CustomValidations
{
    public class PasswordValidator : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string? password)
        {
            var errors = new List<IdentityError>();

            if (password!.Contains(user.UserName!, StringComparison.CurrentCultureIgnoreCase))
            {
                errors.Add(new() { Code = "PasswordContainUserName", Description = "Şifre alanı kullanıcı adı içeremez." });
            }

            if (password.StartsWith("1234", StringComparison.CurrentCultureIgnoreCase))
            {
                errors.Add(new() { Code = "PasswordContain1234", Description = "Şifre alanı ardışık rakam içeremez." });
            }

            if (errors.Count != 0)
            {
                return Task.FromResult(IdentityResult.Failed([.. errors]));
            }

            return Task.FromResult(IdentityResult.Success);
        }
    }
}
