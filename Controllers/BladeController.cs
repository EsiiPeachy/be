using BeybladeMatchMakerAPI.Objects.Models;
using BeybladeMatchMakerAPI.Processes.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace TestBeyBladeAPI.Controllers
{
    [Route("Blade")]
    [ApiController]
    public class BladeController : ControllerBase
    {
        private readonly IBladeProcess bladeProcess;
        public BladeController(IBladeProcess bladeProcess)
        {
            this.bladeProcess = bladeProcess;
        }

        [HttpPost]
        [Route("GetAllBlade")]
        public async Task<ActionResult<List<BladeDto>>> GetAllBlade()
        {
            var resp = await bladeProcess.GetAllBlade();
            return Ok(resp);
        }
    }
}
