namespace Dummy_API.Models
{
    public class Article
    {
        public int id_article { get; set; }
        public string name { get; set; }
        public float base_price { get; set; }
        public string volume_sensitive { get; set; }
        public ICollection<Sale> sales { get; set; }


    }
}
