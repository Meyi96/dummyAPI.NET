namespace Dummy_API.Models
{
    public class Sale
    {
        public int id_sale { get; set; }
        public string volume { get; set; }
        public string season { get; set; }
        public DateTime date_discount   { get; set; }
        public float discount { get; set; }    

    }
}
