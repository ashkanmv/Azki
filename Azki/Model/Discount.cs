using Azki.Enum;

namespace azki.Model
{
    public class Discount : BaseEntity
    {
        public string Code { get; set; }
        public int Percent { get; set; } = 50;
        public bool IsActive { get; set; }
        public string Discription { get; set; }
        public InsuranceTypeEnum InsuranceType { get; set; }
    }
}
