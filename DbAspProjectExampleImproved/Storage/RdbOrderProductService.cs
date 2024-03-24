using DbAspProjectExampleImproved.Entity;
using DbAspProjectExampleImproved.Service;

namespace DbAspProjectExampleImproved.Storage
{
    public class RdbOrderProductService : IOrderProduct
    {
        public Task<OrderProduct?> Add(OrderProduct orderProduct)
        {
            throw new NotImplementedException();
        }

        public Task<OrderProduct?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderProduct>> ListAll()
        {
            throw new NotImplementedException();
        }

        public Task<OrderProduct?> RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderProduct?> UpdateById(int id, OrderProduct orderProduct)
        {
            throw new NotImplementedException();
        }
    }
}
