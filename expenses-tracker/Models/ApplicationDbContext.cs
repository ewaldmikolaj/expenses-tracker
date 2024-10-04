using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace expenses_tracker.Models;

public class ApplicationDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public ApplicationDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }
    
    public DbSet<User> User { get; set; }
    public DbSet<Expense> Expenses { get; set; }
}