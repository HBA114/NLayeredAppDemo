using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete;

public class ProductManager
{
    private ProductDal _productDal;

    public ProductManager(ProductDal productDal)
    {
        _productDal = productDal;
    }

    public List<Product> GetAll()
    {
        // Business code
        return _productDal.GetAll();
    }
}