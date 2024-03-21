using DbAspProjectExampleImproved.Entity;

namespace DbAspProjectExampleImproved.Service
{
    public interface IOrderService
    {
        // добавить категорию
        Task<Order?> Add(Order order);

        // добавить список категорий
        Task<List<Order>> AddRange(List<Order> orders);

        // получить категорию по id
        Task<Order?> GetById(int id);

        // получить список всех категорий
        Task<List<Order>> ListAll();

        // удалить категорию по id
        Task<Order?> RemoveById(int id);

        // редактировать категорию по id
        Task<Order?> UpdateById(int id, Order order);
    }
}
