using Microsoft.EntityFrameworkCore;
using PlatformService.Domain.Models;

namespace PlatformService.DAL.ModelConfigure
{
    internal static class PlatformConfigure
    {
        public static void ConfigurePlatform(this ModelBuilder builder)
        {
            builder.Entity<Platform>().ToTable("platforms");
            builder.Entity<Platform>().Property(x => x.Id).IsRequired(true).HasColumnName("id");
            builder.Entity<Platform>().Property(x => x.Name).IsRequired(true).HasColumnName("name");
            builder.Entity<Platform>().Property(x => x.Publisher).IsRequired(true).HasColumnName("publisher");
            builder.Entity<Platform>().Property(x => x.Cost).IsRequired(true).HasColumnName("cost");
            builder.Entity<Platform>().HasKey(k => k.Id);
        }
    }
}
