using Microsoft.AspNetCore.Mvc;
using SzogunUI.RocketService.Models;

namespace SzogunUI.RocketService.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet]
        [Route("missile-types/")]
        public IActionResult GetMissileTypes()
        {
            return Ok(new[]
            {
                MissileType.Bb,
                MissileType.Parabelum,
                MissileType.Cruise,
                MissileType.TsarBomba
            });
        }
        
        [HttpPut]
        [Route("locations/{latidute}/{longitude}")]
        public IActionResult PutMissilesToLocation(
            [FromRoute]double latitude, 
            [FromRoute]double longitude, 
            [FromBody] MissileSpec spec)
        {
            return Ok();
        }
    }
}