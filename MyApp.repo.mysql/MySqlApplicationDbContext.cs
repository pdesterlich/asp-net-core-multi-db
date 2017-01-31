using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MyApp.repo.mysql
{
    public class MySqlApplicationDbContext: ApplicationDbContext
    {
        public MySqlApplicationDbContext(DbContextOptions options, IConfigurationRoot config): base(options, config)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(Configuration["Data:MySqlConnectionString"]);
        }
    }
}