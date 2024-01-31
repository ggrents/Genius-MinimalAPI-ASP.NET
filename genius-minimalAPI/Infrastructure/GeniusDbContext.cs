using genius_minimalAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace genius_minimalAPI.Infrastructure
{
    public class GeniusDbContext : DbContext
    {
        public GeniusDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Lyrics> Lyrics { get; set; }
        public DbSet<Annotation> Annotations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musician>(o => 
            { 
                o.ToTable("musicians");

                o.Property(p => p.Id).HasColumnName("id");
                o.Property(p => p.Name).HasColumnName("name");
                o.Property(p => p.Surname).HasColumnName("surname");
                o.Property(p => p.Info).HasColumnName("info");
                o.Property(p => p.Age).HasColumnName("age");

                o.HasMany(p => p.Releases)
                .WithOne(p => p.Musician)
                .HasForeignKey(b => b.MusicianId);
            });

            modelBuilder.Entity<Release>(o =>
            {
                o.ToTable("releases");

                o.Property(p => p.Id).HasColumnName("id");
                o.Property(p => p.Name).HasColumnName("name");
                o.Property(p => p.Description).HasColumnName("description");
                o.Property(p => p.ImagePath).HasColumnName("imagePath");

                o.HasMany(p => p.Tracks)
               .WithOne(p => p.Release)
               .HasForeignKey(b => b.ReleaseId);

            });

            modelBuilder.Entity<Track>(o =>
            {
                o.ToTable("tracks");

                o.Property(p => p.Id).HasColumnName("id");
                o.Property(p => p.Name).HasColumnName("name");

 

            });

            modelBuilder.Entity<Lyrics>(o =>
            {
                o.ToTable("lyrics");

                o.Property(p => p.Id).HasColumnName("id");
                o.Property(p => p.Content).HasColumnName("content");

                o.HasOne(p => p.Track)
                .WithOne(p => p.Lyrics)
                .HasForeignKey<Lyrics>(b => b.TrackId);

                o.HasMany(p => p.Annotations)
                .WithOne(p => p.Lyrics)
                .HasForeignKey(p => p.LyricsId);

            });

            modelBuilder.Entity<Annotation>(o =>
            {
                o.ToTable("annotations");

                o.Property(p => p.Id).HasColumnName("id");
                o.Property(p => p.Content).HasColumnName("content");
                o.Property(p => p.FirstSymbol).HasColumnName("first_symbol");
                o.Property(p => p.LastSymbol).HasColumnName("last_symbol");

            });

        }

        }
}
