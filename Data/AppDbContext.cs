using CoureTestProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CoureTestProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetail> CountryDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasKey(c => c.CountryId);

            modelBuilder.Entity<CountryDetail>()
                .HasKey(cd => new { cd.Operator, cd.OperatorCode });

            modelBuilder.Entity<Country>()
                .HasMany(c => c.CountryDetails)
                .WithOne(cd => cd.Country);
               // .HasForeignKey(cd => cd.CountryId);

            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
