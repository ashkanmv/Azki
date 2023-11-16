using azki.Model;

namespace Azki.Dto;

public class GetRandomResponseDto : BaseEntity
{
    public string Personality { get; set; }
    public string Question { get; set; }
    public string SvgUrl { get; set; }

    public IEnumerable<GetResultColor> Options { get; set; }

    public static GetRandomResponseDto MapFromModel(Instrument instrument)
    {
        return new GetRandomResponseDto()
        {
            Personality = instrument.Personality,
            Title = instrument.Title,
            Question = instrument.Question,
            Id = instrument.Id,
            Options = instrument.InstrumentOptions.Select(GetResultColor.MapFromModel),
            SvgUrl = instrument.SvgUrl
        };
    }
}

public class GetResultColor : BaseEntity
{
    public static GetResultColor MapFromModel(InstrumentOption entity)
    {
        return new GetResultColor()
        {
            Title = entity.Title,
            Id = entity.Id
        };
    }
}
