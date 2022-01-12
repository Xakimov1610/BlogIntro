using Microsoft.EntityFrameworkCore;
using blogs.ViewModels;

namespace blogs.Data
{
   public class BlogDbContext : DbContext
{

    public DbSet<BlogViewModel> Blog { get; set; }

    // public DbSet<PostViewModel> Post { get; set; }

    public BlogDbContext(DbContextOptions options)
        : base(options) { }
}
}