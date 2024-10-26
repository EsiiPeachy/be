using BeybladeMatchMakerAPI.Data.Services;
using BeybladeMatchMakerAPI.Objects.Models;
using Microsoft.AspNetCore.Mvc;

namespace TestBeyBladeAPI.Controllers
{
    [Route("Beyblade")]
    [ApiController]
    public class BeybladeController : ControllerBase
    {
        private readonly BeybladeService beybladeService;
        public BeybladeController(BeybladeService beybladeService) 
        {
            this.beybladeService = beybladeService;
        }

        [HttpPost]
        [Route("GetBeyblade")]
        public IActionResult GetBeyblade([FromBody] BeybladeDto req)
        {
            return Ok();
        }
    }
}
