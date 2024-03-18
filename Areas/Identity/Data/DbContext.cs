using ASP_NET_MVC_LOGIN_LOGOUT_2.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ASP_NET_MVC_LOGIN_LOGOUT_2.Models;

namespace ASP_NET_MVC_LOGIN_LOGOUT_2.Areas.Identity.Data;

public class DbContext : IdentityDbContext<ASP_NET_MVC_LOGIN_LOGOUT_2User>
{
    public DbContext(DbContextOptions<DbContext> options)
        : base(options)
    {

     
    }
    public DbSet<Students> students { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ASP_NET_MVC_LOGIN_LOGOUT_2User>
    {
       
        public void Configure(EntityTypeBuilder<ASP_NET_MVC_LOGIN_LOGOUT_2User> builder)
        {
            builder.Property(temp => temp.FirstName).HasMaxLength(12);
            builder.Property(temp => temp.LastName).HasMaxLength(12);
        }
    }
}
