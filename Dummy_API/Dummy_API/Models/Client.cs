namespace Dummy_API.Models
{
    public class Client
    {
        public string name { get; set; }    
        public string frequency_purchase { get; set; }
        public DateTime date_last_purchase  { get; set; }
        public ICollection<Sale> sales { get; set; }

    }
}
