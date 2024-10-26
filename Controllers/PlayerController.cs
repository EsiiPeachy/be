using BeybladeMatchMakerAPI.Objects.Models;
using BeybladeMatchMakerAPI.Processes.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace TestBeyBladeAPI.Controllers
{
    [Route("Player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerProcess playerProcess;
        public PlayerController(IPlayerProcess playerProcess)
        {
            this.playerProcess = playerProcess;
        }

        [HttpPost]
        [Route("GetAllPlayer")]
        public async Task<ActionResult<List<PlayerDto>>> GetAllPlayer()
        {
            var resp = await playerProcess.GetAllPlayer();
            return Ok(resp);
        }
    }
}
