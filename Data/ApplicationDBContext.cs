using Microsoft.EntityFrameworkCore;
using ServiceManager.Models;

namespace ServiceManager.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
        : base(dbContextOptions)
    {
        
    }
    
    public DbSet<Service> Services { get; set; }
    public DbSet<VerList> VerLists { get; set; }
}