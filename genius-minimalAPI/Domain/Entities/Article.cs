namespace genius_minimalAPI.Domain.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public  string? Title { get; set; }
        public string? Content { get; set; }
        public string? ImagePath { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
