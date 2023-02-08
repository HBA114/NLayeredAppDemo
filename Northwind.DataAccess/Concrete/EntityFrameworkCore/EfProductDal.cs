using Microsoft.EntityFrameworkCore;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFrameworkCore;
public class EfProductDal : IProductDal
{
    private readonly NorthwindContext _context;

    public EfProductDal(NorthwindContext context)
    {
        _context = context;
    }

    public List<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Product Get(int id)
    {
        return _context.Products.SingleOrDefault(p => p.ProductId == id)!;
    }

    public void Add(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void Update(Product product)
    {
        // context.Products.Add(product);
        _context.SaveChanges();
    }

    public void Delete(Product product)
    {
        // context.Products.Remove(product);
        // context.SaveChanges();
    }
}