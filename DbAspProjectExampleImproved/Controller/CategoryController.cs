using DbAspProjectExampleImproved.Entity;
using DbAspProjectExampleImproved.Service;
using Microsoft.AspNetCore.Mvc;

namespace DbAspProjectExampleImproved.Controller
{
    // CategoryController - контроллер, включающий в себя операции для работы с категориями товаров
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // сервис для работы с категориями
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<List<Category>> ListAll()
        {
            return await _categoryService.ListAll();
        }

        [HttpGet("{id:int}")]
        public async Task<Category?> GetById(int id)
        {
            Category? category = await _categoryService.GetById(id);
            if (category == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            }
            return category;
        }

        [HttpPost]
        public async Task<Category?> Add(Category category)
        {
            Category? result = await _categoryService.Add(category);
            if (result == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            return result;
        }

        [HttpPost("range")]
        public async Task<List<Category>> AddRange(List<string> categories)
        {
            List<Category> result = await _categoryService.AddRange(
                categories
                .Select(category => new Category() { Description = category})
                .ToList()
            );
            if (result == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            return result;
        }

        [HttpDelete("{id:int}")]
        public async Task<Category?> RemoveById(int id)
        {
            Category? category = await _categoryService.RemoveById(id);
            if (category == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            }
            return category;
        }

        [HttpPatch("{id:int}")]
        public async Task<Category?> UpdateById(int id, Category category)
        {
            Category? updated = await _categoryService.UpdateById(id, category);
            if (updated == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            return updated;
        }
    }
}
