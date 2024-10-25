using Microsoft.EntityFrameworkCore;
using QrCodeGenerator.Models;

namespace QrCodeGenerator.Data;

public class AppDbContext : DbContext
{
    public DbSet<Qr> Qrs { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}