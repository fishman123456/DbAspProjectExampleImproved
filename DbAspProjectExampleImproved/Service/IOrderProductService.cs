using DbAspProjectExampleImproved.Entity;

namespace DbAspProjectExampleImproved.Service
{
    public interface IOrderProductService
    {
        // добавить многие ко многим ЗаказПродукт
        Task<OrderProduct ?> Add(OrderProduct orderProduct);

        // получить ЗаказПродукт по id
        Task<OrderProduct ?> GetById(int id);

        // получить список всех ЗаказПродукт
        Task<List<OrderProduct >> ListAll();

        // удалить ЗаказПродукт по id
        Task<OrderProduct ?> RemoveById(int id);

        // редактировать ЗаказПродукт по id
        Task<OrderProduct ?> UpdateById(int id, OrderProduct orderProduct);
    }
}
