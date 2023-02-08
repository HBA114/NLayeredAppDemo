using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;

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
}