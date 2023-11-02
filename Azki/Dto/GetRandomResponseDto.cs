using azki.Model;

namespace Azki.Dto;

public class GetRandomResponseDto : BaseEntity
{
    public string FullTitle { get; set; }
    public string Description { get; set; }
    public IEnumerable<GetResultColor> Colors { get; set; }

    public static GetRandomResponseDto MapFromModel(Instrument instrument)
    {
        return new GetRandomResponseDto()
        {
            FullTitle = instrument.FullTitle,
            Description = instrument.Description,
            Title = instrument.Title,
            Id = instrument.Id,
            Colors = instrument.InstrumentColors.Select(GetResultColor.MapFromModel)
        };
    }
}

public class GetResultColor : BaseEntity
{
    public static GetResultColor MapFromModel(InstrumentColor entity)
    {
        return new GetResultColor()
        {
            Title = entity.Title,
            Id = entity.Id
        };
    }
}
