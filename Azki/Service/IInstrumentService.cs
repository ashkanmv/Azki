using azki.Dto;
using Azki.Dto;
using azki.Model;

namespace azki.Service
{
    public interface IInstrumentService
    {
        Task<GetResultResponseDto> GetResult(GetResultRequestDto dto);
        Task<IEnumerable<GetRandomResponseDto>> GetRandom();
    }
}
