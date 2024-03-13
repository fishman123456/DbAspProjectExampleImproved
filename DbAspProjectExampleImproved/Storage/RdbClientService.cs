using DbAspProjectExampleImproved.Entity;
using DbAspProjectExampleImproved.Service;
using Microsoft.EntityFrameworkCore;

namespace DbAspProjectExampleImproved.Storage
{
    // RdbClientService - имплементация интерфейса IClientService, работающая с СУБД MS SQL Server
    public class RdbClientService : IClientService
    {
        private readonly ApplicationDbContext _db;

        public RdbClientService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Client?> Add(Client client)
        {
            _db.Clients.Add(client);
            await _db.SaveChangesAsync();
            return client;
        }

        public async Task<Client?> GetById(int id)
        {
            return await _db.Clients.FirstOrDefaultAsync(client => client.Id == id);
        }

        public async Task<List<Client>> ListAll()
        {
            return await _db.Clients.ToListAsync();
        }

        public async Task<Client?> RemoveById(int id)
        {
            Client? removed = await _db.Clients.FirstOrDefaultAsync(client => client.Id == id);
            if (removed != null)
            {
                _db.Clients.Remove(removed);
                await _db.SaveChangesAsync();
            }
            return removed;
        }

        public async Task<Client?> UpdateById(int id, Client client)
        {
            Client? updated = await _db.Clients.FirstOrDefaultAsync(client => client.Id == id);
            if (updated != null)
            {
                updated.FirstName = client.FirstName;
                updated.LastName = client.LastName;
                updated.Email = client.Email;
                updated.BirthDate = client.BirthDate;
                await _db.SaveChangesAsync();
            }
            return updated;
        }
    }
}
