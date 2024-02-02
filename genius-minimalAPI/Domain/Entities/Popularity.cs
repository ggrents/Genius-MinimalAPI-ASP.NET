namespace genius_minimalAPI.Domain.Entities
{
    public class Popularity
    {
        public int Id { get; set; }
        public int ViewCount { get; set; }
        public int MusicianId { get; set; }
        public Musician? Musician { get; set; }
    }
}
