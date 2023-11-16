using Azki.Enum;
using azki.Model;
using azki.Persistence;

namespace azki.Data
{
    public class DataSeed
    {

        //public static async Task SeedAsync(AzkiContext context)
        //{
        //    if (context == null)
        //    {
        //        throw new Exception("Context is null!");
        //    }

        //    if (context.Instruments.Any() == false)
        //    {
        //        context.Instruments.AddRange(GetData());
        //        context.Discounts.AddRange(GetDiscountData());

        //        await context.SaveChangesAsync();
        //        //logger.LogInformation("data seed completed.");
        //    }

        //}

        //private static List<Discount> GetDiscountData()
        //{
        //    return new List<Discount>()
        //    {
        //        new()
        //        {
        //            Title = "کد تخفیف 1",
        //            Code = "123",
        //            IsActive = true,
        //            Percent = 20,
        //            InsuranceType = InsuranceTypeEnum.Crash
        //        },
        //        new()
        //        {

        //            Title = "کد تخفیف 2",
        //            Code = "234",
        //            IsActive = true,
        //            Percent = 30,
        //            InsuranceType = InsuranceTypeEnum.Home
        //        },
        //        new()
        //        {
        //            Title = "کد تخفیف 3",
        //            Code = "345",
        //            IsActive = true,
        //            Percent = 99,
        //            InsuranceType = InsuranceTypeEnum.Full
        //        },
        //        new()
        //        {
        //            Title = "کد تخفیف 4",
        //            Code = "445",
        //            IsActive = true,
        //            Percent = 85,
        //            InsuranceType = InsuranceTypeEnum.RightHand
        //        },
        //        new()
        //        {
        //            Title = "کد تخفیف 5",
        //            Code = "545",
        //            IsActive = true,
        //            Percent = 75,
        //            InsuranceType = InsuranceTypeEnum.ThirdPerson
        //        },
        //        new()
        //        {
        //            Title = "کد تخفیف 6",
        //            Code = "645",
        //            IsActive = true,
        //            Percent = 35,
        //            InsuranceType = InsuranceTypeEnum.Mobile
        //        },
        //        new()
        //        {
        //            Title = "کد تخفیف 7",
        //            Code = "745",
        //            IsActive = true,
        //            Percent = 12,
        //            InsuranceType = InsuranceTypeEnum.Home
        //        },
        //        new()
        //        {
        //            Title = "کد تخفیف 8",
        //            Code = "845",
        //            IsActive = true,
        //            Percent = 9,
        //            InsuranceType = InsuranceTypeEnum.Full
        //        },
        //        new()
        //        {
        //            Title = "کد تخفیف 9",
        //            Code = "945",
        //            IsActive = true,
        //            Percent = 42,
        //            InsuranceType = InsuranceTypeEnum.RightHand
        //        },
        //        new()
        //        {
        //            Title = "کد تخفیف 10",
        //            Code = "1045",
        //            IsActive = true,
        //            Percent = 32,
        //            InsuranceType = InsuranceTypeEnum.Crash
        //        }
        //    };
        //}
        //private static List<Instrument> GetData()
        //{
             
        //}
    }
}

