using System.Text.Json.Serialization;

namespace DbAspProjectExampleImproved.Entity
{
    // Produ - класс, опсиывающий сущность клиента магазина
    public class Product
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int quantity  { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        // навигационные свойства
        [JsonIgnore]
        public ICollection<OrderProduct>? OrderProducts { get; set; }
        public Product()
        {
            title = string.Empty;
            description = string.Empty;
            price = 0;
            quantity = 0;
        }

        public override string ToString()
        {
            return $"{Id} - {title} - {description} - {price} - {quantity}";
        }
    }
}

