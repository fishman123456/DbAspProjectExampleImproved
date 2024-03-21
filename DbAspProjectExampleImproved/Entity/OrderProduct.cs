namespace DbAspProjectExampleImproved.Entity
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Quantity}";
        }
    }
}
