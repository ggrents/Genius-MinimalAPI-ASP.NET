using genius_minimalAPI.Application.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace genius_minimalAPI.Presentation.Endpoints
{
    public static class TracksEndpoints
    {
        public static void MapTracksEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/tracks");
            group.MapGet("", GetAllTracks);
            group.MapGet("/{trackId:int}", GetTrackById);
            group.MapGet("/musician/{musicianId:int}", GetTracksByMusician);
        }


        private static async Task<IResult> GetAllTracks([FromServices] ITrackRepository rep)
        {
            var _tracks = await rep.GetAllTracksAsync();
            return Results.Ok(_tracks);
        }

        private static async Task<IResult> GetTrackById(int trackId, [FromServices] ITrackRepository rep)
        {
            var _track = await rep.GetTrackByIdAsync(trackId);
            return Results.Ok(_track);
        }

        private static async Task<IResult> GetTracksByMusician(int musicianId, [FromServices] ITrackRepository rep)
        {
            var _tracks = await rep.GetTracksByMusicianAsync(musicianId);
            return Results.Ok(_tracks);
        }
    }
}
