using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract;

public interface IProductService
{
    List<Product> GetAll();
    List<Product> GetByCategory(int categoryId);
    List<Product> GetByName(string name);
}