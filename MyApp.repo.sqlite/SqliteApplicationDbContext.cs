using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MyApp.repo.sqlite
{
    public class SqliteApplicationDbContext: ApplicationDbContext
    {
        public SqliteApplicationDbContext(DbContextOptions options, IConfigurationRoot config) : base(options, config)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(Configuration["Data:SqliteConnectionString"]);
        }

    }
}