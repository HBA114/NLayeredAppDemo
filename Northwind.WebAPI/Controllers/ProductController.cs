using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;

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
}