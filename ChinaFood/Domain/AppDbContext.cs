using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ChinaFood.Domain
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
