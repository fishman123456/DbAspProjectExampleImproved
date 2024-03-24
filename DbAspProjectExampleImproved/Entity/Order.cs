using System.Text.Json.Serialization;

namespace DbAspProjectExampleImproved.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatationDate { get; set; }
        public bool IsCompleted { get; set; }
        public Client client { get; set; }
        // навигационные свойства
        [JsonIgnore]
        public ICollection<OrderProduct>? OrderProducts { get; set; }
        public Order()
        {
            Description = string.Empty;
            IsCompleted = false;
        }
        public override string ToString()
        {
            return $"{Id} - {Description} - {CreatationDate} - {IsCompleted}";
        }
    }
}
