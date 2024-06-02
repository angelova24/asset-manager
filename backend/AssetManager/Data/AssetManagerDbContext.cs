using AssetManager.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetManager.Data;

public class AssetManagerDbContext : DbContext
{
    public AssetManagerDbContext(DbContextOptions<AssetManagerDbContext> options): base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
}