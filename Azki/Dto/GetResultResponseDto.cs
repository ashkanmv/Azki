using azki.Dto;
using azki.Model;

namespace Azki.Dto
{
    public class GetResultResponseDto
    {
        public string FullTitle { get; set; }
        public string Body { get; set; }
        public string DiscountCode { get; set; }
        public string DiscountTitle { get; set; }
        public string SvgUrl { get; set; }
        public static GetResultResponseDto MapFromModel(Instrument instrument, InstrumentOption option, Discount discount)
        {
            return new GetResultResponseDto()
            {
                Body = instrument.Description + "/n" + option.Description,
                DiscountCode = discount.Code,
                DiscountTitle = discount.Title,
                FullTitle = instrument.FullTitle,
                SvgUrl = instrument.SvgUrl
            };
        }
    }
}
