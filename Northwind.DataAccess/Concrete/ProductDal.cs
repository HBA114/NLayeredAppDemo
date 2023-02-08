using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete;

public class ProductDal
{
    private readonly NorthwindContext context;

    public ProductDal(NorthwindContext context)
    {
        this.context = context;
    }

    public List<Product> GetAll()
    {
        return context.Products.ToList();
    }

    public Product Get(int id)
    {
        return context.Products.SingleOrDefault(p => p.ProductId == id)!;
    }

    public void Add(Product product)
    {
        context.Products.Add(product);
        context.SaveChanges();
    }

    public void Update(Product product)
    {
        // context.Products.Add(product);
        context.SaveChanges();
    }

    public void Delete(Product product)
    {
        //     context.Products.Remove(product);
        //     context.SaveChanges();
    }
}