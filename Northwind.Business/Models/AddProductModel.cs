namespace Northwind.Business.Models;

public record AddProductModel 
{
    public int CategoryId { get; set; }   
    public string? ProductName { get; set; }
    public string? QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public Int16 UnitsInStock { get; set; }
}