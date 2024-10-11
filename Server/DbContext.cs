using Microsoft.EntityFrameworkCore;
using BlazorTestApp.Shared;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) {}

    public DbSet<Product> Products { get; set; }
}
