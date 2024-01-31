namespace genius_minimalAPI.Domain.Entities
{
    public class Lyrics
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public int TrackId { get; set; }
        public Track? Track { get; set; }
        public ICollection<Annotation>? Annotations { get; set; }
    }
}
