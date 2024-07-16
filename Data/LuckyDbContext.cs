using Lucky.WebAPI.Configuration;
using Lucky.WebAPI.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lucky.WebAPI.Data
{
    public class LuckyDbContext : IdentityDbContext<LuckyUser>
    {
        public LuckyDbContext(DbContextOptions<LuckyDbContext> options)
            : base(options)
        {  
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new LanguageConfiguration());
        }
    }
}
