using Azki.Dto;

namespace Azki.Service;

public interface IAuthService
{
    Task<bool> Authenticate(AuthenticateUserRequestDto dto);
    Task<VerifyResponseDto> Verify(AzkiVerifyRequestDto dto);
}
