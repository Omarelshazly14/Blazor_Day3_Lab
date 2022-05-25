using Microsoft.EntityFrameworkCore;
using Lab.Shared;

namespace Lab.WebApi.Models
{
    public class Context:DbContext
    {
        public Context()
        { 
        }
        public Context(DbContextOptions options):base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
