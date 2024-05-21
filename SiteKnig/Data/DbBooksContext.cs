using Microsoft.EntityFrameworkCore;
using SiteKnig.Models;

namespace SiteKnig.Data
{
    public class DbBooksContext : DbContext
    {
        public DbBooksContext(DbContextOptions<DbBooksContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {  
                entity.Property(dd => dd.Id).ValueGeneratedOnAdd();
                entity.Property (t => t.Title).IsRequired();
                entity.Property(a => a.Author).IsRequired();
                entity.Property(d => d.DatePublication).HasColumnType("date").IsRequired();        
            });
        }
    }
}
