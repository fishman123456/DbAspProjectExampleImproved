using DbAspProjectExampleImproved.Entity;
using DbAspProjectExampleImproved.Service;
using Microsoft.EntityFrameworkCore;

namespace DbAspProjectExampleImproved.Storage
{
    // RdbProductService - имплементация интерфейса IProductService, работающая с СУБД MS SQL Server
    public class RdbProductService : IProductService
    {
        private readonly ApplicationDbContext _db;

        public RdbProductService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Product?> Add(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public Task<Product?> GetById(int id)
        {
            return _db.Products.FirstOrDefaultAsync(product => product.Id == id);
        }

        public async Task<List<Product>> ListAll()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task<Product?> RemoveById(int id)
        {
            Product? removed = await _db.Products.FirstOrDefaultAsync(product =>product.Id == id);
            if (removed != null)
            {
                _db.Products.Remove(removed);
                await _db.SaveChangesAsync();
            }
            return removed;
        }

        public async Task<Product?> UpdateById(int id, Product product)
        {
            Product? update = await _db.Products.FirstOrDefaultAsync(product => product.Id == id);
            if (update != null)
            {
                update.price = product.price;
                update.quantity = product.quantity;
                update.title = product.title;
                update.description = product.description;
                await _db.SaveChangesAsync();
            }
            return update;
        }
    }
}
