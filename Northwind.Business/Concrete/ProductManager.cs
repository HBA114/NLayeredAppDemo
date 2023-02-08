using Northwind.DataAccess.Concrete.EntityFrameworkCore;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete;

public class ProductManager
{
    private EfProductDal _productDal;

    public ProductManager(EfProductDal productDal)
    {
        _productDal = productDal;
    }

    public List<Product> GetAll()
    {
        // Business code
        return _productDal.GetAll();
    }
}