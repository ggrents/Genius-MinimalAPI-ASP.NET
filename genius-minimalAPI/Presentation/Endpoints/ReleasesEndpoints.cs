using genius_minimalAPI.Application.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace genius_minimalAPI.Presentation.Endpoints
{
    public static class ReleasesEndpoints
    {
        public static void MapReleasesEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/releases");
            group.MapGet("", GetAllReleases);
            group.MapGet("/{releaseId:int}", GetReleaseById);
            group.MapGet("/musician/{musicianId:int}", GetReleasesByMusician);
        }


        private static async Task<IResult> GetAllReleases([FromServices] IReleaseRepository rep)
        {
            var _releases = await rep.GetAllReleasesAsync();
            return Results.Ok(_releases);
        }

        private static async Task<IResult> GetReleaseById(int releaseId, [FromServices] IReleaseRepository rep)
        {
            var _release = await rep.GetReleaseByIdAsync(releaseId);
            return Results.Ok(_release);
        }

        private static async Task<IResult> GetReleasesByMusician(int musicianId, [FromServices] IReleaseRepository rep)
        {
            var _releases = await rep.GetReleasesByMusicianAsync(musicianId);
            return Results.Ok(_releases);
        }
    }
}

