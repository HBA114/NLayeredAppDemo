using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Abstract;

public interface IProductDal
{
    List<Product> GetAll();
    Product Get(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);
}