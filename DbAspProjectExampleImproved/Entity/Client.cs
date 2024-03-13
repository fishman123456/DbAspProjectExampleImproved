namespace DbAspProjectExampleImproved.Entity
{
    // Client - класс, опсиывающий сущность клиента магазина
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get ; set; }  
        
        public Client()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }

        public override string ToString()
        {
            return $"{Id} - {FirstName} - {LastName} - {Email} - {BirthDate}";
        }
    }
}
