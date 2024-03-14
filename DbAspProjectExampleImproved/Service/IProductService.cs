using DbAspProjectExampleImproved.Entity;

namespace DbAspProjectExampleImproved.Service
{
    // IProductService - сервис, описывающий работу с продуктами (базовый CRUD)
    public interface IProductService
    {
        // добавить клиента
        Task<Product?> Add(Product product);

        // получить клиента по id
        Task<Product?> GetById(int id);

        // получить список всех клиентов
        Task<List<Product>> ListAll();

        // удалить клиента по id
        Task<Product?> RemoveById(int id);

        // редактировать клиента по id
        Task<Product?> UpdateById(int id, Product product);
    }
}
