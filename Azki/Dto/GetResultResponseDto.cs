using azki.Dto;
using azki.Model;

namespace Azki.Dto
{
    public class GetResultResponseDto
    {
        public string FinalPersonality { get; set; }
        public string InstrumentResult { get; set; }
        public string OptionResult { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountPercent { get; set; }
        public string DiscountTitle { get; set; }
        public string DiscountDescription { get; set; }
        public string SvgUrl { get; set; }
        public static GetResultResponseDto MapFromModel(Instrument instrument, InstrumentOption option)
        {
            return new GetResultResponseDto()
            {
                InstrumentResult = instrument.Result,
                OptionResult = option.Description,
                DiscountCode = instrument.Discount.Code,
                DiscountTitle = instrument.Discount.Title,
                DiscountDescription = instrument.Discount.Discription,
                DiscountPercent = instrument.Discount.Percent,
                FinalPersonality = instrument.FinalPersonality,
                SvgUrl = instrument.SvgUrl
            };
        }
    }
}
