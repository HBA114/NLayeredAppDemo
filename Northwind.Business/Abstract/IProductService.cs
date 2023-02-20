using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract;

public interface IProductService
{
    List<Product> GetAll();
    List<Product> GetByCategory(int categoryId);
    List<Product> GetByName(string name);
    Product GetById(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(int id);
}