using Microsoft.EntityFrameworkCore;
using CunDropShipping_Order.infrastructure.Entity;

namespace CunDropShipping_Order.infrastructure.DbContext;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public AppDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<OrderEntity> Orders { get; set; } = null!;
}
