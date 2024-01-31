namespace genius_minimalAPI.Domain.Entities

{
    public class Track
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ReleaseId { get; set; }
        public Release? Release { get; set; }
        public Lyrics? Lyrics { get; set; }
        public int LyricsId { get; set; }
    }
}
