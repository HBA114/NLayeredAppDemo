using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.Business.Models;
using Northwind.Entities.Concrete;

namespace Northwind.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : Controller
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(_productService.GetAll());
    }

    [HttpGet("GetByCategory")]
    public IActionResult GetProductsByCategory(int categoryId)
    {
        return Ok(_productService.GetByCategory(categoryId));
    }

    [HttpGet("GetByName")]
    public IActionResult GetProductsByName(string name)
    {
        return Ok(_productService.GetByName(name));
    }

    [HttpGet("GetById/{id}")]
    public IActionResult GetProductById([FromRoute] int id)
    {
        return Ok(_productService.GetById(id));
    }

    [HttpPost("Add")]
    public IActionResult AddProduct(AddProductModel model)
    {
        Product product = new()
        {
            CategoryId = model.CategoryId,
            ProductName = model.ProductName,
            UnitPrice = model.UnitPrice,
            UnitsInStock = model.UnitsInStock,
            QuantityPerUnit = model.QuantityPerUnit
        };
        _productService.Add(product);
        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateProduct(UpdateProductModel updateProductModel)
    {
        Product product = new()
        {
            ProductId = updateProductModel.ProductId,
            ProductName = updateProductModel.ProductName,
            CategoryId = updateProductModel.CategoryId,
            UnitPrice = updateProductModel.UnitPrice,
            QuantityPerUnit = updateProductModel.QuantityPerUnit,
            UnitsInStock = updateProductModel.UnitsInStock
        };

        _productService.Update(product);
        return Ok();
    }

    [HttpDelete("/{id}")]
    public IActionResult DeleteProduct([FromRoute] int id)
    {
        _productService.Delete(id);
        return Ok();
    }
}