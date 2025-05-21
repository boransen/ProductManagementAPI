using Microsoft.AspNetCore.Mvc;
using ProductManagementAPI.Data;

namespace ProductManagementAPI.Controllers;

[ApiController]
[Route("api/categories")]
public class CategoriesController : ControllerBase
{
    private readonly AppDbContext _context;

    public CategoriesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_context.Categories.ToList());
}
