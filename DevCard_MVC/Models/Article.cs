namespace DevCard_MVC.Models
{
    public class Article
    {
        public long id { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string image { get; set; }


        public Article(long id, string title, string description, string image)
        {
            this.id = id ;
            this.title = title;
            this.description = description;
            this.image = image;
        }
    }
}