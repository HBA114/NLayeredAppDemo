using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete;

public class ProductManager : IProductService
{
    private IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public void Add(Product product)
    {
        _productDal.Add(product);
    }

    public void Delete(int id)
    {
        _productDal.Delete(_productDal.Get(p => p.ProductId == id));
    }

    public List<Product> GetAll()
    {
        // Business code
        return _productDal.GetAll();
    }

    public List<Product> GetByCategory(int categoryId)
    {
        return _productDal.GetAll(p => p.CategoryId == categoryId);
    }

    public Product GetById(int id)
    {
        return _productDal.Get(p => p.ProductId == id);
    }

    public List<Product> GetByName(string name)
    {
        return _productDal.GetAll(p => p.ProductName!.ToLower().Contains(name.ToLower()));
    }

    public void Update(Product product)
    {
        _productDal.Update(product);
    }
}