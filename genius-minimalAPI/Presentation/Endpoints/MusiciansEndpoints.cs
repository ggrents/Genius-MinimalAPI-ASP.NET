using genius_minimalAPI.Application.Repository;
using Microsoft.AspNetCore.Mvc;

namespace genius_minimalAPI.Presentation.Endpoints
{
    public static class MusiciansEndpoints
    {
        public static void MapMusicianEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/musicians");
            group.MapGet("", GetAllMusicians);
            group.MapGet("/musicianId", GetMusicianById);
        }


        private static async Task<IResult> GetAllMusicians([FromServices] IMusicianRepository rep)
        {
            var _musicians = await rep.GetAllMusiciansAsync();
            return Results.Ok(_musicians);
        }

        private static async Task<IResult> GetMusicianById(int musicianId, [FromServices] IMusicianRepository rep)
        {
            var _musician = await rep.GetMusicianByIdAsync(musicianId);
            return Results.Ok(_musician);
        }
    }
}

