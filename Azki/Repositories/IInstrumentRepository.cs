using Azki.Enum;
using azki.Model;

namespace azki.Repositories
{
    public interface IInstrumentRepository
    {
        Instrument Get(long id);
        List<Instrument> GetAll();
    }
}
