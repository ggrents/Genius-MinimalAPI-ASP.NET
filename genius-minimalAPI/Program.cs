using genius_minimalAPI.Application.Repository;
using genius_minimalAPI.Application.Repository.ReleasesRep;
using genius_minimalAPI.Infrastructure;
using genius_minimalAPI.Presentation.Endpoints;
using Microsoft.EntityFrameworkCore;


namespace genius_minimalAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<GeniusDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IMusicianRepository, MusicianRepository>();
            builder.Services.AddScoped<ITrackRepository, TrackRepository>();
            builder.Services.AddScoped<IReleaseRepository, ReleasesRepository>();
            builder.Services.AddScoped<ILyricsRepository, LyricsRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapMusicianEndpoints();
            app.MapReleasesEndpoints();
            app.MapTracksEndpoints();
            app.Run();
        }
    }
}