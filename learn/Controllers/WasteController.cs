using Entities;
using Integrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Models.Response;

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

        [HttpGet("GetWaste", Name = "GetWaste")]
        public IActionResult Get(string city)
        {
            try{
                string lang = Request.Headers.AcceptLanguage;
                return Ok(CitiesFactory
                    .GetWasteRepository(city)
                    .GetWaste(lang ?? ""));
            }
            catch (Exception e)
            {
                return BadRequest(new ExceptionResponseModel(e.Message));
            }
        }
        [HttpGet("Outages")]
        public IActionResult GetOutages(string city)
        {
            try
            {
                string lang = Request.Headers.AcceptLanguage;
                return Ok(CitiesFactory
                          .GetOutagesRepository(city)
                          .GetOutage(lang ?? ""));
            }
            catch (Exception e)
            {
                return BadRequest(new ExceptionResponseModel(e.Message));
            }
        }
    }
}
