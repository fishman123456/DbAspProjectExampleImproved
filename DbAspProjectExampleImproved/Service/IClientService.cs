using DbAspProjectExampleImproved.Entity;

namespace DbAspProjectExampleImproved.Service
{
    // IClientService - сервис, описывающий работу с клиентами (базовый CRUD)
    public interface IClientService
    {
        // добавить клиента
        Task<Client?> Add(Client client);

        // получить клиента по id
        Task<Client?> GetById(int id);

        // получить список всех клиентов
        Task<List<Client>> ListAll();

        // удалить клиента по id
        Task<Client?> RemoveById(int id);

        // редактировать клиента по id
        Task<Client?> UpdateById(int id, Client client);
    }
}
