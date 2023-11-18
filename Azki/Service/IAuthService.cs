using Azki.Dto;

namespace Azki.Service;

public interface IAuthService
{
    Task<string> Authenticate(AuthenticateUserRequestDto dto);
    Task<VerifyResponseDto> Verify(AzkiVerifyRequestDto dto);
}
