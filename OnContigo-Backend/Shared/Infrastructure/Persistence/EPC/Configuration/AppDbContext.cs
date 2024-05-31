using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using OnContigo_Backend.Users.Domain.Model.Aggregates;
using OnContigo_Backend.Shared.Infrastructure.Persistence.EPC.Configuration.Extensions;


namespace OnContigo_Backend.Shared.Infrastructure.Persistence.EPC.Configuration
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.AddCreatedUpdatedInterceptor();
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            /*
            builder.Entity<>().ToTable("F");
            builder.Entity<>().HasKey(f => f.Id);
            builder.Entity<>().Property(f => f.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<>().Property(f => f.NewsApiKey).IsRequired();
            builder.Entity<>().Property(f => f.SourceId).IsRequired();
            **/
            builder.UseSnakeCaseNamingConvention();

        }
    }
}
