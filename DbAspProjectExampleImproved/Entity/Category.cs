using System.Text.Json.Serialization;

namespace DbAspProjectExampleImproved.Entity
{
    // Category - категории товаров
    public class Category
    {
        // поля категории
        public int Id { get; set; }
        public string Description { get; set; }

        // навигационные свойства
        [JsonIgnore]
        public ICollection<Product>? Products { get; set; } 

        public Category()
        {
            Description = "";
        }

        public override string ToString()
        {
            return $"{Id} - {Description}";
        }
    }
}
