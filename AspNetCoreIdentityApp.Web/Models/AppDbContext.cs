using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AspNetCoreIdentityApp.Web.Models
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {

    }
}
