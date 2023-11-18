using Azki.Dto;
using System.Text;
using System.Text.Json;

namespace Azki.Service;

public class AuthService : IAuthService
{
    private readonly string baseUrl;

    public AuthService(IConfiguration configuration)
    {
        baseUrl = configuration.GetSection("AzkiBaseUrl").Value;
    }

    public async Task<string> Authenticate(AuthenticateUserRequestDto dto)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, baseUrl + "/v2/api/customer/auth");
        request.Content = new StringContent(JsonSerializer.Serialize(dto), Encoding.UTF8, "application/json");

        var response = await client.SendAsync(request);

        var result = JsonSerializer.Deserialize<AzkiResponseDto<string>>(await response.Content.ReadAsStringAsync());


        if (result is not { messageCode: 200 })
            throw new Exception(result?.message);

        return result.result;
    }

    public async Task<VerifyResponseDto> Verify(AzkiVerifyRequestDto dto)
    {
        var accessToken = await GetAccessToken(dto);

        var result = await GetProfile(accessToken);
        return result;
    }


    private async Task<string> GetAccessToken(AzkiVerifyRequestDto dto)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, baseUrl + "/v2/api/customer/auth/verify");
        request.Content = new StringContent(JsonSerializer.Serialize(dto), Encoding.UTF8, "application/json");

        var response = await client.SendAsync(request);
        var responseDto = JsonSerializer.Deserialize<AzkiResponseDto<AzkiVerifyResponseDto>>(await response.Content.ReadAsStringAsync());

        if (responseDto is not { messageCode: 200 })
            throw new Exception(responseDto?.message);

        return responseDto.result.access_token;
    }

    private async Task<VerifyResponseDto> GetProfile(string accessToken)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/v2/api/customer/auth/profile");
        request.Headers.Add("Authorization", "bearer " + accessToken);

        var response = await client.SendAsync(request);
        var responseDto = JsonSerializer.Deserialize<AzkiResponseDto<VerifyResponseDto>>(await response.Content.ReadAsStringAsync());

        if (responseDto is not { messageCode: 200 })
            throw new Exception(responseDto?.message);

        return responseDto.result;
    }
}
