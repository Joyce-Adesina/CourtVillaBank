using CourtVillaBank.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace CourtVillaBank.Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Account> accounts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        
    }
}
