namespace Dummy_API.Models
{
    public class company
    {
        public int id_company { get; set; } 
        public  string name { get; set; }   
        public string description { get; set; }
        public ICollection<Article> articules { get; set; } 

    }
}
