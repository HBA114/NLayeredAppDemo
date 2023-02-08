using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;

namespace Northwind.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : Controller 
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_categoryService.GetAll());
    }
}