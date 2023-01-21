using Entities;
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

        [HttpGet(Name = "GetWaste")]
        public WasteResponseModel Get(string city)
        {
            return CityWasteRepositoryFactory.GetRepository(city).GetWaste();
        }
    }
}
