using Northwind.Entities.Abstract;

namespace Northwind.Entities.Concrete;

public class Category : IEntity
{   
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }

    public Category(int categoryId, string categoryName)
    {
        CategoryId = categoryId;
        CategoryName = categoryName;
    }

    public Category()
    {
    }
}