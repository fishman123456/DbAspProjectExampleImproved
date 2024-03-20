using DbAspProjectExampleImproved.Entity;

namespace DbAspProjectExampleImproved.Service
{
    // ICategoryService - сервис для работы с категориями
    public interface ICategoryService
    {
        // добавить категорию
        Task<Category?> Add(Category category);

        // добавить список категорий
        Task<List<Category>> AddRange(List<Category> categories);

        // получить категорию по id
        Task<Category?> GetById(int id);

        // получить список всех категорий
        Task<List<Category>> ListAll();

        // удалить категорию по id
        Task<Category?> RemoveById(int id);

        // редактировать категорию по id
        Task<Category?> UpdateById(int id, Category category);
    }
}
