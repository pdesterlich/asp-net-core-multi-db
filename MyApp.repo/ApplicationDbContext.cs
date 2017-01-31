using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyApp.models;

namespace MyApp.repo
{
    public abstract class ApplicationDbContext: DbContext
    {
        protected readonly IConfigurationRoot Configuration;
        public DbSet<Customer> Customers { get; set; }

        protected ApplicationDbContext(DbContextOptions options, IConfigurationRoot config): base(options)
        {
            Configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}