using AspNetCoreIdentityApp.Web.Models;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentityApp.Web.CustomValidations
{
    public class UserValidator : IUserValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            var errors = new List<IdentityError>();

            var isDigit = int.TryParse(user.UserName![0].ToString(), out _);

            if (isDigit)
            {
                errors.Add(new() { Code = "UserNameContainFirstLetterDigit", Description = "Kullanıcı adının ilk karakteri sayısal bir karakter içeremez." });
            }

            if (errors.Count != 0)
            {
                return Task.FromResult(IdentityResult.Failed([.. errors]));
            }

            return Task.FromResult(IdentityResult.Success);
        }
    }
}
