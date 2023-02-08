using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFrameworkCore;
public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
{
    public EfCategoryDal(NorthwindContext context) : base(context) { }
}