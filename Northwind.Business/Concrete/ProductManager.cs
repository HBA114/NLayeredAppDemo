using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete;

public class ProductManager
{
    ProductDal _productDal = new ProductDal();
    public List<Product> GetAll()
    {
        // Business code
        return _productDal.GetAll();
    }
}