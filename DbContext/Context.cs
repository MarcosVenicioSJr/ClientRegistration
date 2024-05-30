using ClientRegistration.Mapping;
using ClientRegistration.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientRegistration.DbContext;

public class Context : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Client> Client { get; set; }
    
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            connectionString: "Server=localhost,1433;Database=ClientRegistration;User ID=sa;Password=1q2w3e4r@#$; Trusted_Connection=False; TrustServerCertificate=True;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClientMapping());
    }
}