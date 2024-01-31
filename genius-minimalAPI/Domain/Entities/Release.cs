namespace genius_minimalAPI.Domain.Entities
{
    public class Release
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }        
        public string? ImagePath { get; set; }
        public ICollection<Track> Tracks { get; set; }
        public int MusicianId { get; set; }
        public Musician? Musician { get; set;}
    }
}
