using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using ProductCollege.Areas.Identity.Data;

namespace ProductCollege.Areas.Identity.Data;

public class ProductCollegeContext : IdentityDbContext<ProductCollegeUser>
{
    public ProductCollegeContext(DbContextOptions<ProductCollegeContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
   
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ProductCollegeUser>
{
    public void Configure(EntityTypeBuilder<ProductCollegeUser> builder)
    {
       builder.Property(x=>x.FirstName).HasMaxLength(255);   
        builder.Property(x=>x.LastName).HasMaxLength(255);
        builder.Property(x=>x.MobileNo).HasMaxLength(255);
    }
}