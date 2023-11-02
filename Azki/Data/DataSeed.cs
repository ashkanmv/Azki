using Azki.Enum;
using azki.Model;
using azki.Persistence;

namespace azki.Data
{
    public class DataSeed
    {

        public static async Task SeedAsync(AzkiContext context)
        {
            if (context == null)
            {
                throw new Exception("Context is null!");
            }

            if (context.Instruments.Any() == false)
            {
                context.Instruments.AddRange(GetData());
                context.Discounts.AddRange(GetDiscountData());

                await context.SaveChangesAsync();
                //logger.LogInformation("data seed completed.");
            }

        }

        private static List<Discount> GetDiscountData()
        {
            return new List<Discount>()
            {
                new()
                {
                    Title = "کد تخفیف 1",
                    Code = "123",
                    IsActive = true,
                    Percent = 20,
                    InsuranceType = InsuranceTypeEnum.Crash
                },
                new()
                {

                    Title = "کد تخفیف 2",
                    Code = "234",
                    IsActive = true,
                    Percent = 30,
                    InsuranceType = InsuranceTypeEnum.Home
                },
                new()
                {
                    Title = "کد تخفیف 3",
                    Code = "345",
                    IsActive = true,
                    Percent = 99,
                    InsuranceType = InsuranceTypeEnum.Full
                },
                new()
                {
                    Title = "کد تخفیف 4",
                    Code = "445",
                    IsActive = true,
                    Percent = 85,
                    InsuranceType = InsuranceTypeEnum.RightHand
                },
                new()
                {
                    Title = "کد تخفیف 5",
                    Code = "545",
                    IsActive = true,
                    Percent = 75,
                    InsuranceType = InsuranceTypeEnum.ThirdPerson
                },
                new()
                {
                    Title = "کد تخفیف 6",
                    Code = "645",
                    IsActive = true,
                    Percent = 35,
                    InsuranceType = InsuranceTypeEnum.Mobile
                },
                new()
                {
                    Title = "کد تخفیف 7",
                    Code = "745",
                    IsActive = true,
                    Percent = 12,
                    InsuranceType = InsuranceTypeEnum.Home
                },
                new()
                {
                    Title = "کد تخفیف 8",
                    Code = "845",
                    IsActive = true,
                    Percent = 9,
                    InsuranceType = InsuranceTypeEnum.Full
                },
                new()
                {
                    Title = "کد تخفیف 9",
                    Code = "945",
                    IsActive = true,
                    Percent = 42,
                    InsuranceType = InsuranceTypeEnum.RightHand
                },
                new()
                {
                    Title = "کد تخفیف 10",
                    Code = "1045",
                    IsActive = true,
                    Percent = 32,
                    InsuranceType = InsuranceTypeEnum.Crash
                }
            };
        }
        private static List<Instrument> GetData()
        {
            return new List<Instrument>()
            {
                new Instrument
                {
                    InstrumentColors = new List<InstrumentColor>()
                    {
                        new()
                        {
                            Description = "توضیح رنگ 1",
                            Title = "عنوان رنگ 1"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 2",
                            Title = "عنوان رنگ 2"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 3",
                            Title = "عنوان رنگ 3"
                        }
                    },
                    Title = "عنوان 1",
                    Description = "توضیح 1",
                    FullTitle = "عنوان کامل 1",
                    Result = "نتیجه 1",
                    InsuranceType = InsuranceTypeEnum.Crash,
                    SvgUrl = "https://s31.picofile.com/file/8469200592/4.jpg"
                },
                new Instrument
                {
                    InstrumentColors = new List<InstrumentColor>()
                    {
                        new()
                        {
                            Description = "توضیح رنگ 4",
                            Title = "عنوان رنگ 4"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 5",
                            Title = "عنوان رنگ 5"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 6",
                            Title = "عنوان رنگ 6"
                        }
                    },
                    Title = "عنوان 2",
                    Description = "توضیح 2",
                    FullTitle = "عنوان کامل 2",
                    Result = "نتیجه 2",
                    InsuranceType = InsuranceTypeEnum.Full,
                    SvgUrl = "https://s31.picofile.com/file/8469200576/m.jpg"
                },
                new Instrument
                {
                    InstrumentColors = new List<InstrumentColor>()
                    {
                        new()
                        {
                            Description = "توضیح رنگ 7",
                            Title = "عنوان رنگ 7"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 8",
                            Title = "عنوان رنگ 8"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 9",
                            Title = "عنوان رنگ 9"
                        }
                    },
                    Title = "عنوان 3",
                    Description = "توضیح 3",
                    FullTitle = "عنوان کامل 3",
                    Result = "نتیجه 3",
                    InsuranceType = InsuranceTypeEnum.Home,
                    SvgUrl = "https://s31.picofile.com/file/8469200626/3.jpg"
                },
                new Instrument
                {
                    InstrumentColors = new List<InstrumentColor>()
                    {
                        new()
                        {
                            Description = "توضیح رنگ 10",
                            Title = "عنوان رنگ 10"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 11",
                            Title = "عنوان رنگ 11"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 12",
                            Title = "عنوان رنگ 12"
                        }
                    },
                    Title = "عنوان 4",
                    Description = "توضیح 4",
                    FullTitle = "عنوان کامل 4",
                    Result = "نتیجه 4",
                    InsuranceType = InsuranceTypeEnum.Mobile,
                    SvgUrl = "https://s31.picofile.com/file/8469200642/2.jpg"
                },
                new Instrument
                {
                    InstrumentColors = new List<InstrumentColor>()
                    {
                        new()
                        {
                            Description = "توضیح رنگ 13",
                            Title = "عنوان رنگ 13"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 14",
                            Title = "عنوان رنگ 14"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 15",
                            Title = "عنوان رنگ 15"
                        }
                    },
                    Title = "عنوان 5",
                    Description = "توضیح 5",
                    FullTitle = "عنوان کامل 5",
                    Result = "نتیجه 5",
                    InsuranceType = InsuranceTypeEnum.RightHand,
                    SvgUrl = "https://s31.picofile.com/file/8469200650/1.jpg"
                },
                new Instrument
                {
                    InstrumentColors = new List<InstrumentColor>()
                    {
                        new()
                        {
                            Description = "توضیح رنگ 16",
                            Title = "عنوان رنگ 16"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 17",
                            Title = "عنوان رنگ 17"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 18",
                            Title = "عنوان رنگ 18"
                        }
                    },
                    Title = "عنوان 6",
                    Description = "توضیح 6",
                    FullTitle = "عنوان کامل 6",
                    Result = "نتیجه 6",
                    InsuranceType = InsuranceTypeEnum.ThirdPerson,
                    SvgUrl = "https://s31.picofile.com/file/8469200668/sh.jpg"
                },
                new Instrument
                {
                    InstrumentColors = new List<InstrumentColor>()
                    {
                        new()
                        {
                            Description = "توضیح رنگ 19",
                            Title = "عنوان رنگ 19"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 20",
                            Title = "عنوان رنگ 20"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 21",
                            Title = "عنوان رنگ 21"
                        }
                    },
                    Title = "عنوان 7",
                    Description = "توضیح 7",
                    FullTitle = "عنوان کامل 7",
                    Result = "نتیجه 7",
                    InsuranceType = InsuranceTypeEnum.Mobile,
                    SvgUrl = "https://s31.picofile.com/file/8469200650/1.jpg"
                },
                new Instrument
                {
                    InstrumentColors = new List<InstrumentColor>()
                    {
                        new()
                        {
                            Description = "توضیح رنگ 22",
                            Title = "عنوان رنگ 22"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 23",
                            Title = "عنوان رنگ 23"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 24",
                            Title = "عنوان رنگ 24"
                        }
                    },
                    Title = "عنوان 8",
                    Description = "توضیح 8",
                    FullTitle = "عنوان کامل 8",
                    Result = "نتیجه 8",
                    InsuranceType = InsuranceTypeEnum.Full,
                    SvgUrl = "https://s31.picofile.com/file/8469200592/4.jpg"
                },
                new Instrument
                {
                    InstrumentColors = new List<InstrumentColor>()
                    {
                        new()
                        {
                            Description = "توضیح رنگ 25",
                            Title = "عنوان رنگ 25"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 26",
                            Title = "عنوان رنگ 26"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 27",
                            Title = "عنوان رنگ 27"
                        }
                    },
                    Title = "عنوان 9",
                    Description = "توضیح 9",
                    FullTitle = "عنوان کامل 9",
                    Result = "نتیجه 9",
                    InsuranceType = InsuranceTypeEnum.ThirdPerson,
                    SvgUrl = "https://s31.picofile.com/file/8469200626/3.jpg"
                },
                new Instrument
                {
                    InstrumentColors = new List<InstrumentColor>()
                    {
                        new()
                        {
                            Description = "توضیح رنگ 28",
                            Title = "عنوان رنگ 28"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 29",
                            Title = "عنوان رنگ 29"
                        },
                        new()
                        {
                            Description = "توضیح رنگ 30",
                            Title = "عنوان رنگ 30"
                        }
                    },
                    Title = "عنوان 10",
                    Description = "توضیح 10",
                    FullTitle = "عنوان کامل 10",
                    Result = "نتیجه 10",
                    InsuranceType = InsuranceTypeEnum.Crash,
                    SvgUrl = "https://s31.picofile.com/file/8469200592/4.jpg"
                },
            };
        }
    }
}

