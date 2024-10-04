using Microsoft.EntityFrameworkCore;
using MY_Blog.Models;

namespace MY_Blog.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        // BlogPost modeli için veritabanı tablosu
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
