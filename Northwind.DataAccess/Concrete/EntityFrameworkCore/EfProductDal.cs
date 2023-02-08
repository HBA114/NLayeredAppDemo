using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFrameworkCore;

public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
{
    public EfProductDal(NorthwindContext context) : base(context) { }
}