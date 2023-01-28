using Entities;
using Integrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace learn.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WasteController : ControllerBase
    {
        private readonly ILogger<WasteController> _logger;
        private readonly IStringLocalizer<WasteController> _localizer;

        public WasteController(ILogger<WasteController> logger, IStringLocalizer<WasteController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        [HttpGet(Name = "GetWaste")]
        public IActionResult Get(string city)
        {
            try{
                return Ok(CitiesFactory.GetWasteRepository(city).GetWaste());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
