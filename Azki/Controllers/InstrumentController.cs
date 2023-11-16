using System.Text.Json;
using azki.Dto;
using azki.Service;
using Azki.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace azki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentController : ControllerBase
    {
        private readonly IInstrumentService _instrumentService;
        private readonly LogRepository _log;
        public InstrumentController(IInstrumentService instrumentService, LogRepository log)
        {
            _instrumentService = instrumentService;
            _log = log;
        }

        [HttpGet]
        public async Task<IActionResult> GetInstruments()
        {
            return Ok(await _instrumentService.GetRandom());
        }

        [HttpPost]
        public async Task<IActionResult> GetResult(GetResultRequestDto dto)
        {
            try
            {
                return Ok(await _instrumentService.GetResult(dto));
            }
            catch (Exception e)
            {
                await _log.AddLog("GetResult Body : + " + JsonSerializer.Serialize(dto) + " \n Exception : " +
                                  e.Message + " \n" + "Inner Exception : " + e.InnerException?.Message);
                //return BadRequest("خطای فنی");
                return BadRequest("GetResult Exception : " + e.Message + " \n" + "Inner Exception : " + e.InnerException?.Message);
            }
        }
    }
}
