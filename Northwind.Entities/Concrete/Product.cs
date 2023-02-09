using Northwind.Entities.Abstract;

namespace Northwind.Entities.Concrete;

public class Product : IEntity
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public decimal UnitPrice { get; set; }
    public string QuantityPerUnit { get; set; }
    public Int16 UnitsInStock { get; set; }

    public Product(int productId, string productName, int categoryId, decimal unitPrice, string quantityPerUnit, short unitsInStock)
    {
        ProductId = productId;
        ProductName = productName;
        CategoryId = categoryId;
        UnitPrice = unitPrice;
        QuantityPerUnit = quantityPerUnit;
        UnitsInStock = unitsInStock;
    }

    public Product()
    {
    }
}