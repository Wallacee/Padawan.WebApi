using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Padawan.WebApi.Model;
using System.IO;
namespace Padawan.WebApi.Dal
{
    public class Context : DbContext
    {
        public Context() : base() { }
        public Context(DbContextOptions<Context> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.GlobalConfiguration();
            modelBuilder
                .Entity<User>()
                .HasMany<Photo>(p => p.Photos)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }


    }
}
