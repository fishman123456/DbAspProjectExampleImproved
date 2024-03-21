using DbAspProjectExampleImproved.Entity;
using DbAspProjectExampleImproved.Service;

using Microsoft.EntityFrameworkCore;

namespace DbAspProjectExampleImproved.Storage
{
    public class RdbOrderService : IOrderService
    {
        private readonly ApplicationDbContext _db;

        public RdbOrderService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Order?> Add(Order order)
        {
           _db.Orders.Add(order);
            await _db.SaveChangesAsync();
            return order;
        }

        public async Task<List<Order>> AddRange(List<Order> orders)
        {
            await _db.Orders.AddRangeAsync(orders);
            await _db.SaveChangesAsync();
            return orders;
        }

        public async Task<Order?> GetById(int id)
        {
            return await _db.Orders.FirstOrDefaultAsync( order => order.Id == id);
        }

        public async Task<List<Order>> ListAll()
        {
            return await _db.Orders.ToListAsync();
        }

        public async Task<Order?> RemoveById(int id)
        {
           Order? removed = await _db.Orders.FirstOrDefaultAsync(order  => order.Id == id);
            if (removed != null)
            {
                _db.Orders.Remove(removed);
               await _db.SaveChangesAsync();
            }
            return removed;
        }

        public async Task<Order?> UpdateById(int id, Order order)
        {
            Order? updated = await _db.Orders.FirstOrDefaultAsync(order => order.Id == id);
            if (updated != null)
            {
                updated.Description = order.Description;
                await _db.SaveChangesAsync();
            }
            return updated;
        }
    }
}
