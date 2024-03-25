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


//{
//    "Description":"товар на ура",
//    "IsCompleted": false,
//    "CreatationDate": "2023-11-02",
//    "Client": {
//        "FirstName":"dens",
//        "LastName":"Lada",
//        "Email":"l@ya.ru",
//        "birthDate": "2020-01-02"
//    }
//}