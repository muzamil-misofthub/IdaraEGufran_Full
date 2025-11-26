using Microsoft.EntityFrameworkCore;
using IEG.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IEG.Infrastructure.Models;

namespace IEG.Infrastructure.Data
{
    //public class AppDbContext:DbContext
    //public class AppDbContext:IdentityDbContext
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
