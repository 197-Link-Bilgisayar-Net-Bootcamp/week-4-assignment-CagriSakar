using RedisApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace RedisApp.Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("category/getall")]
        public IActionResult GetAll()
        {
            return Ok(_categoryService.GetAllCategory());
        }
    }
}
