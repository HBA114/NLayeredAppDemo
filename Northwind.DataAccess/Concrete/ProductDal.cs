using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete;

public class ProductDal
{
    public List<Product> GetAll()
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return context.Products.ToList();
        }
    }

    public Product Get(int id)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return context.Products.SingleOrDefault(p => p.ProductId == id)!;
        }
    }

    public void Add(Product product)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }

    public void Update(Product product)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            // context.Products.Add(product);
            context.SaveChanges();
        }
    }

    public void Delete(Product product)
    {
        // using (NorthwindContext context = new NorthwindContext())
        // {
        //     context.Products.Remove(product);
        //     context.SaveChanges();
        // }
    }
}