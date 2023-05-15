using Microsoft.EntityFrameworkCore;
using TheWillStock.Models;

namespace TheWillStock.Data
{
    public class DataContext : DbContext
    {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }


    public DbSet<ProductModel> ProductModel { get; set; } = default!;
    }
}
