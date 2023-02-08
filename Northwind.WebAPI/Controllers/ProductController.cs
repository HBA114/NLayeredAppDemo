using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFrameworkCore;

namespace Northwind.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : Controller
{
    private readonly ProductManager _productManager;

    public ProductController(ProductManager productManager)
    {
        _productManager = productManager;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(_productManager.GetAll());
    }
}