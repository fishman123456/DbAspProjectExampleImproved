using System.Text.Json.Serialization;

namespace DbAspProjectExampleImproved.Entity
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        // навигационные свойства
        [JsonIgnore]
        public Order? Order { get; set; }
        public Product? Product { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Quantity}";
        }
    }
}
