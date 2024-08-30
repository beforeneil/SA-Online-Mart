using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EHA_Assignment_SAOnlineMart.Models;

namespace EHA_Assignment_SAOnlineMart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EHA_Assignment_SAOnlineMart.Models.Product> Product { get; set; } = default!;
    }
}
