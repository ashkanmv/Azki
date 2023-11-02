using Azki.Enum;
using azki.Model;

namespace azki.Repositories
{
    public interface IInstrumentRepository
    {
        Task<Instrument> Get(long id);
        Task<List<Instrument>> GetAll();
        Task<Discount?> GetDiscount(InsuranceTypeEnum type);
        Task<int> UpdateDiscount(Discount discount);
    }
}
