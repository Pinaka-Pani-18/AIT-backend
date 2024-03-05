using AIT_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace AIT_backend.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
