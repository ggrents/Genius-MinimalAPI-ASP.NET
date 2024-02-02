namespace genius_minimalAPI.Domain.Entities
{
    public class Musician
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
        public string? Surname { get; set; }    
        public string? Nickname { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Info { get; set; }
        public ICollection<Release>? Releases { get; set; }
        public Popularity? Popularity { get; set; }
    }
}
