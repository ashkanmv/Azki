using Azki.Enum;
using azki.Model;
using azki.Persistence;
using Microsoft.EntityFrameworkCore;

namespace azki.Repositories
{
    public class InstrumentRepository : IInstrumentRepository
    {
        protected readonly AzkiContext AzkiContext;
        public InstrumentRepository(AzkiContext azkiContext)
        {
            AzkiContext = azkiContext;
        }


        public async Task<Instrument> Get(long id)
        {
            return await AzkiContext.Instruments.Include(x => x.InstrumentColors).FirstAsync(x => x.Id == id);
        }

        public async Task<List<Instrument>> GetAll()
        {
            return await AzkiContext.Instruments.Include(x => x.InstrumentColors).ToListAsync();
        }

        public async Task<Discount?> GetDiscount(InsuranceTypeEnum type)
        {
            return await AzkiContext.Discounts.FirstOrDefaultAsync(d => d.InsuranceType == type && d.IsActive);
        }

        public async Task<int> UpdateDiscount(Discount discount)
        {
            AzkiContext.Discounts.Update(discount);
            return await AzkiContext.SaveChangesAsync();
        }
    }

}
