using System.ComponentModel.DataAnnotations;

namespace azki.Model
{
    public class InstrumentOption : BaseEntity
    {
        public InstrumentOption()
        {
            Instruments = new HashSet<Instrument>();
        }
        [Required]
        public string Description { get; set; }
        public ICollection<Instrument> Instruments { get; set; }
    }
}
