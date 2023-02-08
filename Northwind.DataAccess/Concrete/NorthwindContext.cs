using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete;

public class NorthwindContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}