using System.ComponentModel.DataAnnotations;

namespace azki.Model
{
    public class InstrumentColor : BaseEntity
    {
        public InstrumentColor()
        {
            Instruments = new HashSet<Instrument>();
        }
        [Required]
        public string Description { get; set; }
        public ICollection<Instrument> Instruments { get; set; }
    }
}
