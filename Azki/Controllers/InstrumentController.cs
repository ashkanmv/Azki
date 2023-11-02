using azki.Dto;
using azki.Service;
using Microsoft.AspNetCore.Mvc;

namespace azki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentController : ControllerBase
    {
        private readonly IInstrumentService _instrumentService;

        public InstrumentController(IInstrumentService instrumentService)
        {
            _instrumentService = instrumentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetInstruments()
        {
            return Ok(await _instrumentService.GetRandom());
        }

        [HttpPost]
        public async Task<IActionResult> GetResult(GetResultRequestDto dto)
        {
            return Ok(await _instrumentService.GetResult(dto));
        }
    }
}
