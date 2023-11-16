using System.Text.Json;
using Azki.Dto;
using Azki.Service;
using Microsoft.AspNetCore.Mvc;

namespace Azki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Authenticate(AuthenticateUserRequestDto dto)
        {
            try
            {
                if (dto == null || string.IsNullOrEmpty(dto.phoneNumber)) return BadRequest("Invalid Credentials");

                var response = await _authService.Authenticate(dto);

                return Ok(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Authenticate Body : + " + JsonSerializer.Serialize(dto) + " \n Exception : " + e.Message + " \n" + "Inner Exception : " + e.InnerException?.Message);
                //return BadRequest("خطای فنی");
                return BadRequest("Authenticate Exception : " + e.Message + " \n" + "Inner Exception : " + e.InnerException?.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Verify(AzkiVerifyRequestDto dto)
        {
            try
            {
                if (dto == null || string.IsNullOrEmpty(dto.phoneNumber) || string.IsNullOrEmpty(dto.verifyCode))
                    return BadRequest("Invalid Credentials");

                var response = await _authService.Verify(dto);

                return Ok(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Authenticate Body "+ JsonSerializer.Serialize(dto) +" \n Exception : " + e.Message + " \n" + "Inner Exception : " + e.InnerException?.Message);
                //return BadRequest("خطای فنی");
                return BadRequest("Authenticate Exception : " + e.Message + " \n" + "Inner Exception : " + e.InnerException?.Message);
            }
        }
    }
}
