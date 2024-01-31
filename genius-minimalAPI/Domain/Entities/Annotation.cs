namespace genius_minimalAPI.Domain.Entities
{
    public class Annotation
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public int FirstSymbol { get; set; }
        public int LastSymbol { get; set; }
        public int LyricsId { get; set; }
        public Lyrics? Lyrics { get; set; }
    }
}
