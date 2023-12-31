﻿using Azki.Enum;

namespace azki.Model
{
    public class Instrument : BaseEntity
    {
        public Instrument()
        {
            InstrumentOptions = new HashSet<InstrumentOption>();
        }
        public string FinalPersonality { get; set; }
        public string Personality { get; set; }
        public string Question { get; set; }
        //public string Description { get; set; }
        public string Result { get; set; }
        public string SvgUrl { get; set; }
        public InsuranceTypeEnum InsuranceType { get; set; }
        public ICollection<InstrumentOption> InstrumentOptions { get; set; }
        public Discount Discount { get; set; }
    }
}
