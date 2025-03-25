using Microsoft.EntityFrameworkCore;
using ProjecteAccessBBDDHugo.Model;

namespace ProjecteAccessBBDDHugo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Simulation> Simulations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
