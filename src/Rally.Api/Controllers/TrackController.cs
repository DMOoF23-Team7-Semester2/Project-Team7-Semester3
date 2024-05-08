using Microsoft.AspNetCore.Mvc;
using Rally.Application.Dto.Track;
using Rally.Application.Interfaces;

namespace Rally.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrackController : ControllerBase
    {
        private readonly ITrackService _trackService;

        public TrackController(ITrackService trackService)
        {
            _trackService = trackService;
        }

        [HttpGet("GetAllTracks")]
        public async Task<IActionResult> GetTracks()
        {
            var tracks = await _trackService.GetAll();
            return Ok(tracks);
        }

        [HttpGet("GetTrackWithCategory")]
        public async Task<ActionResult<TrackWithCategoryDto>> GetTrackWithCategory(int id)
        {
            var track = await _trackService.GetTrackWithCategory(id);
            return Ok(track);
        }

        [HttpGet("LoadTrack")]
        public async Task<ActionResult<LoadTrackDto>> LoadTrack(int id)
        {
            var track = await _trackService.LoadTrack(id);
            return Ok(track);
        }

        [HttpPost("CreateTrack")]
        public async Task<IActionResult> CreateTrack(CreateTrackDto trackDto)
        {
            var track = await _trackService.Create(trackDto);
            return Ok(track);
        }

        [HttpPut("UpdateTrack")]
        public async Task<IActionResult> UpdateTrack(TrackDto trackDto)
        {
            await _trackService.Update(trackDto);
            return Ok();
        }

        [HttpDelete("DeleteTrack")]
        public async Task<IActionResult> DeleteTrack(int id)
        {
            await _trackService.Delete(id);
            return Ok();
        }
    }
}

