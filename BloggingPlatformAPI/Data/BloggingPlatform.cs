using BloggingPlatformAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BloggingPlatformAPI.Data;

public class BloggingPlatform : DbContext
{
    public BloggingPlatform(DbContextOptions options) { }
    public DbSet<BlogPost> BlogPost { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=BloggingPlatform;" +
            "Trusted_Connection=True;ConnectRetryCount=0");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlogPost>().HasData(
            new BlogPost
            {
                Id = 6,
                Title = "Title",
                content = "Content",
                Category = "Tech",
                Tags = "Python, Software",
                CreatedAt = new DateTime(2025, 02, 17),
                UpdatedAt = new DateTime(2025, 02, 17)
            }
        );
    }
}
