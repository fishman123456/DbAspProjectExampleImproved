using DbAspProjectExampleImproved.Entity;
using DbAspProjectExampleImproved.Service;
using Microsoft.EntityFrameworkCore;

namespace DbAspProjectExampleImproved.Storage
{
    public class RdbCategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _db;

        public RdbCategoryService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Category?> Add(Category category)
        {
            _db.Categories.Add(category);
            await _db.SaveChangesAsync();
            return category;
        }

        public async Task<List<Category>> AddRange(List<Category> categories)
        {
            await _db.Categories.AddRangeAsync(categories);
            await _db.SaveChangesAsync();
            return categories;
        }

        public async Task<Category?> GetById(int id)
        {
            return await _db.Categories.FirstOrDefaultAsync(category => category.Id == id);
        }

        public async Task<List<Category>> ListAll()
        {
            return await _db.Categories.ToListAsync();
        }

        public async Task<Category?> RemoveById(int id)
        {
            Category? removed = await _db.Categories.FirstOrDefaultAsync(category => category.Id == id);
            if (removed != null)
            {
                _db.Categories.Remove(removed);
                await _db.SaveChangesAsync();
            }
            return removed;
        }

        public async Task<Category?> UpdateById(int id, Category category)
        {
            Category? updated = await _db.Categories.FirstOrDefaultAsync(category => category.Id == id);
            if (updated != null)
            {
                updated.Description = category.Description;
                await _db.SaveChangesAsync();
            }
            return updated;
        }
    }
}
